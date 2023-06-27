using MongoDB.Driver;
using System.Diagnostics;
using ConsoleApp1.Models;

mongoInitializer();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void mongoInitializer()
{
    var mongo = Process.Start("Server/server.bat");

    Task.Delay(2000).Wait();
    MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

    var dbList = dbClient.ListDatabases().ToList();

    Console.WriteLine("The list of databases on this server is: ");
    foreach (var db in dbList)
    {
        Console.WriteLine(db);
    }
}

static void testing(){
    var client = new MongoClient("mongodb://localhost:27017");
    var database = client.GetDatabase("project");
    var teamsDB = database.GetCollection<Group>("groups");
    List<Group> groups = teamsDB.Find(d => true).ToList();
    var foo = 0;
}
