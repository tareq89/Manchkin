using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodorAnalysis.Model
{
 
    public class Location
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Path
    {
        public string type { get; set; }
        public List<List<double>> coordinates { get; set; }
    }

    public class IntersectionPoints
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }

        
        [BsonRepresentation(BsonType.ObjectId)]
        public string IntersectionId { get; set; }
        public int Weight { get; set; }
        public int Heading { get; set; }
        public int osm_id { get; set; }
        public Path Path { get; set; }
        public int wayId { get; set; }
        public int Order { get; set; }
    }
}
