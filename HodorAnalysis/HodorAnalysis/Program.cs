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
            //DownloadDataFromMongo ob = new DownloadDataFromMongo();
            //ob.getIntersectionPointsData();
            //ob.getIntersectionsData();
            //ob.originsData();

            // Construct the detailed intersection points
            List<IntersectionPoints> intersectionPoints = JsonConvert.DeserializeObject<List<IntersectionPoints>>(File.ReadAllText(@"C:\Users\Zarvis\Documents\visual studio 2015\Projects\Manchkin\HodorAnalysis\jsonData\intersectionPoints.json"));
            List<Intersections> intersections = JsonConvert.DeserializeObject<List<Intersections>>(File.ReadAllText(@"C:\Users\Zarvis\Documents\visual studio 2015\Projects\Manchkin\HodorAnalysis\jsonData\intersections.json"));
            List<Origins> origins = JsonConvert.DeserializeObject<List<Origins>>(File.ReadAllText(@"C:\Users\Zarvis\Documents\visual studio 2015\Projects\Manchkin\HodorAnalysis\jsonData\origins.json"));
            List<DetailIntersectionPoint> detailsIntersectionPoints = new List<DetailIntersectionPoint>();

            int i = 0;
            foreach (var intersectionpoint in intersectionPoints)
            {                                
                foreach (var intersection in intersections)
                {
                    if (intersectionpoint.IntersectionId.Equals(intersection._id))
                    {
                        foreach (var origin in origins)
                        {
                            if (intersection.OriginId.Equals(origin._id))
                            {
                                var detailIntersectionPoint = new DetailIntersectionPoint() { IntersectionPoint = intersectionpoint , Intersection = intersection, Origin = origin};
                                detailsIntersectionPoints.Add(detailIntersectionPoint);

                                Console.WriteLine(i++ + ": \nOrigin : {0} \nIntersection : {1}\nIntersectionPoint : {2}\n\n\n",
                                    origin.Name, intersection.Name, intersectionpoint.Name);
                            }
                        }
                    }
                }
            }

            File.WriteAllText(Constants.filePath + "/detailedIntersectionList.json", JsonConvert.SerializeObject(detailsIntersectionPoints));
            Console.WriteLine("Finished");
            Console.ReadLine();
        }


    }
}
