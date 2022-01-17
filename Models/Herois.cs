using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projectC.Models
{
    public class HeroisDCMarvel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
       
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Company { get; set; }
        public int Weaknesses { get; set; }
        public int Powers { get; set; }
        public int Life { get; set; }

        public HeroisDCMarvel(string id, string name, string company, int weaknesses, int powers, int life)
        {
            Id = id;
            Name = name;
            Company = company;
            Weaknesses = weaknesses;
            Powers = powers;
            Life = life;
        }
    }
}