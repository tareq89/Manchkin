using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodorAnalysis.Model
{
    public class Intensitys
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string IntersectionId { get; set; }
        public string Intensity { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Time { get; set; }
        
        public int __v { get; set; }
        
        public string Ref { get; set; }        
        public string IntersectionPointId { get; set; }
        public string ProviderId { get; set; }
        public string Batch { get; set; }
        public int IntensityWeight { get; set; }
    }

}
