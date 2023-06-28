using System.Diagnostics;
using AppProject.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

mongoInitializer();
//mongoTests();

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
}

static void mongoTests()
{

    MongoCRUD db = new MongoCRUD("myDB");
    List<Group> recs = db.LoadRecords<Group>("groups");
    Update();
    Read();


    void Update()
    {
        using (StreamReader r = new StreamReader("prueba.json"))
        {
            Console.WriteLine("Ha entrado en Update");
            string json = r.ReadToEnd();
            Group items = Newtonsoft.Json.JsonConvert.DeserializeObject<Group>(json);
            Console.WriteLine(items.Id);
            var oneRec = db.LoadRecordById<Group>("groups", new string(items.group_name));
            Console.WriteLine(items.group_name);
            //db.InsertRecord("groups", items);
            int forTotalScore = items.projects.score;
            Console.WriteLine(forTotalScore);
            oneRec.total_score = forTotalScore;

            db.UpsertRecord("groups", items.group_name, oneRec);
            Console.WriteLine(items.total_score);
        }

    }

    void Read()
    {
        foreach (var r in recs)
        {
            Console.WriteLine($"{r.Id}: {r.group_name} {r.total_score}");
            Console.WriteLine($"{r.projects.project_name} {r.projects.score}");
        }
    }

    Console.ReadLine();
}
