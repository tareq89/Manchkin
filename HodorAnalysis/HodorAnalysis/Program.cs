using HodorAnalysis.DB;
using HodorAnalysis.Helper;
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

namespace HodorAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Constants.filePath + "/100000intensitys.json";
            List<Intensitys> intensitys = JsonConvert.DeserializeObject<List<Intensitys>>(File.ReadAllText(filePath));
            List<DetailIntersectionPoint> detailedIntersectionPoints = JsonConvert.DeserializeObject<List<DetailIntersectionPoint>>(Constants.filePath + "/detailedIntersectionList.json");
            
            var intersectionPointIdCount = intensitys.Where(x => x.IntersectionPointId != null).Count();
            
            Console.ReadLine();
        }
        


    }
}
