using MongoDB.Bson;
using MongoDB.Driver;

public class MongoCRUD
{
    private IMongoDatabase db;
    public MongoCRUD(string database)
    {
        var client = new MongoClient();
        db = client.GetDatabase(database);
    }

    public void InsertRecord<T>(string table, T record)
    {
        var collection = db.GetCollection<T>(table);
        collection.InsertOne(record);
    }

    public List<T> LoadRecords<T>(string table)
    {
        var collection = db.GetCollection<T>(table);

        return collection.Find(new BsonDocument()).ToList();
    }

    public T LoadRecordById<T>(string table, string groupName)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("group_name", groupName);
        Console.WriteLine("ABS" + collection.Find(filter).FirstOrDefault());

        return collection.Find(filter).FirstOrDefault();
    }

    public void UpsertRecord<Group>(string table, string groupName, Group record)
    {
        var collection = db.GetCollection<Group>(table);

        try
        {
            var idProperty = typeof(Group).GetProperty("Id");
            var idValue = idProperty.GetValue(record);
            Console.WriteLine(idValue);
            Console.WriteLine(idProperty);

            var filter = Builders<Group>.Filter.And(
                Builders<Group>.Filter.Eq("group_name", groupName),
                Builders<Group>.Filter.Eq("Id", idValue)
            );

            Console.WriteLine(collection.Find<Group>(filter));


            var result = collection.ReplaceOne(filter, record, new ReplaceOptions { IsUpsert = true });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}