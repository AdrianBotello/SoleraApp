using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Project
    {
        [BsonElement("project_name")]

        String ProjectName { get; set; }

        [BsonElement("score")]
        int Score { get; set; } 

    }
}
