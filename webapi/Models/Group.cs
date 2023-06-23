using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleApp1.Models
{
    public class Group {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("group_name")]
        public string GroupName {get;set;}
        [BsonElement("total_score")]
        public int Total { get; set; }
        [BsonElement("projects")]
        public Project[] Projects { get; set; }
        
    


    }
}
