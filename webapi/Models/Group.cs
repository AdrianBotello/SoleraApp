using System;
using MongoDB.Bson.Serialization.Attributes;

namespace AppProject.Models
{
    public class Group
    {
        [BsonId] // _id
        public Guid Id { get; set; }
        public string group_name { get; set; }
        public int total_score { get; set; }
        public Project projects { get; set; }
    }
}
