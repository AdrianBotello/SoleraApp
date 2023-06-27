using MongoDB.Bson;
using MongoDB.Driver;
using ConsoleApp1.Models;
class GroupController{

    
    private void DatabaseCall() 
    {
        var dbClient = new MongoClient("mongodb://localhost:27019");
        var dataBase = dbClient.GetDatabase("groupDB");
        var groupCollection = dataBase.GetCollection<Group>("groups"); 

        //var fil = Builders<BsonDocument>.Filter.Eq("GroupName", "Nombrerupo");
    }
    public String GroupsAllInfo()
    {
        GroupController databaseController = new GroupController();
        databaseController.DatabaseCall();
        return "";
    }

    public String GroupModify()
    {
        GroupController databaseController = new GroupController();
        databaseController.DatabaseCall();
        return "";
    }

}