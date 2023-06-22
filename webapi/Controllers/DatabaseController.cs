using MongoDB.Bson;
using MongoDB.Driver;

class DatabaseController{
    static void main(String[] args)
    {
        var dbClient = new MongoClient("EmptyAddress");
        IMongoDatabase db = dbClient.GetDatabase("nombreBaseDatos");
        var emp = db.GetCollection<BsonDocument>("nombreCollection");

        var fil = Builders<BsonDocument>.Filter.Eq("GroupName", "Nombrerupo");
    }
}