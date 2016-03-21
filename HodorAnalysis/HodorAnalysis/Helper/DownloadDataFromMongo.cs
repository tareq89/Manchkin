using HodorAnalysis.DB;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodorAnalysis.Helper
{
    class DownloadDataFromMongo
    {
        
        MongoContext context = new MongoContext();
        BsonDocument filter = new BsonDocument();
        public void getIntersectionPointsData()
        {
            var data = context.IntersectionPoints.Find(filter).ToList();
            File.WriteAllText(Constants.filePath + "/intersectionPoints.json", JsonConvert.SerializeObject(data));
            Console.WriteLine(data.Count);
        }
        public void getIntersectionsData()
        {
            var data = context.Intersections.Find(filter).ToList();
            File.WriteAllText(Constants.filePath + "/intersections.json", JsonConvert.SerializeObject(data));
            Console.WriteLine(data.Count);
        }

        public void originsData()
        {
            var data = context.Origins.Find(filter).ToList();
            File.WriteAllText(Constants.filePath + "/origins.json", JsonConvert.SerializeObject(data));
            Console.WriteLine(data.Count);
        }
    }
}
