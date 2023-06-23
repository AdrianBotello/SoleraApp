using ConsoleApp1.Models;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("project");
var teamsDB = database.GetCollection<Teams>("groups");
List<Teams> groups = teamsDB.Find(d => true).ToList();
var foo = 0;
