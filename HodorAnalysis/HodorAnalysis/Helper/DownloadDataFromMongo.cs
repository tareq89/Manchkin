using HodorAnalysis.DB;
using HodorAnalysis.Model;
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
        public void GetIntersectionPointsData()
        {
            var data = context.IntersectionPoints.Find(filter).ToList();
            File.WriteAllText(Constants.filePath + "/intersectionPoints.json", JsonConvert.SerializeObject(data));
            Console.WriteLine(data.Count);
        }
        public void GetIntersectionsData()
        {
            var data = context.Intersections.Find(filter).ToList();
            File.WriteAllText(Constants.filePath + "/intersections.json", JsonConvert.SerializeObject(data));
            Console.WriteLine(data.Count);
        }

        public void GetOriginsData()
        {
            var data = context.Origins.Find(filter).ToList();
            File.WriteAllText(Constants.filePath + "/origins.json", JsonConvert.SerializeObject(data));
            Console.WriteLine(data.Count);
        }
        static void GetIntensityData()
        {
            MongoContext context = new MongoContext();
            var filter = new BsonDocument();
            List<Intensitys> intensitys = new List<Intensitys>();
            var count = context.Intensitys.Count(filter);
            for (int i = 0; i < 100000; i += 1000)
            {
                try
                {
                    var cursor = context.Intensitys.Find(filter).SortBy(x => x.Time).Skip(i).Limit(1000).ToList();
                    intensitys.AddRange(cursor);
                    Console.WriteLine(i + " : " + cursor.Count);
                    File.WriteAllText(Constants.filePath + "/intensitys/" + i + "intensitys.json", JsonConvert.SerializeObject(cursor));
                }
                catch (Exception e)
                {
                    Console.WriteLine("skip : " + i);
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\n\n\n");
                }

            }
            File.WriteAllText(Constants.filePath + "/100000intensitys.json", JsonConvert.SerializeObject(intensitys));

            Console.ReadLine();
        }
    }
}
