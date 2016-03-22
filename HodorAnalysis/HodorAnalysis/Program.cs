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
            string detailFilePath = Constants.filePath + "/detailedIntersectionList.json";
            List<Intensitys> intensitys = JsonConvert.DeserializeObject<List<Intensitys>>(File.ReadAllText(filePath));
            List<DetailIntersectionPoint> detailedIntersectionPoints = JsonConvert.DeserializeObject<List<DetailIntersectionPoint>>(File.ReadAllText(detailFilePath));
            List<IntersectionIntensityReport> reports = new List<IntersectionIntensityReport>();

            var intersectionPointIdCount = intensitys.Where(x => x.IntersectionPointId != null).OrderBy(x=>x.Time.DayOfYear);
            IntersectionIntensityReport report = null;
            int dayOfTheYearFlag = 0;
            int counter = 0;

            foreach (var intersectionPoint in detailedIntersectionPoints) 
            {
                report = new IntersectionIntensityReport();                
                foreach (var intensity in intersectionPointIdCount)
                {
                    if (report.DetailedIntersectionPoint == null && intersectionPoint.IntersectionPoint._id.Equals(intensity.IntersectionPointId))
                    {
                        Console.WriteLine(intensity.Time.DayOfYear + "   -   " + intersectionPoint.IntersectionPoint.Name);
                        report.DetailedIntersectionPoint = detailedIntersectionPoints.Where(x => x.IntersectionPoint._id.Equals(intensity.IntersectionPointId)).FirstOrDefault();                        
                        report.StartDate = intensity.Time;
                        
                    }
                    if (report.DetailedIntersectionPoint != null && report.DetailedIntersectionPoint.IntersectionPoint._id.Equals(intensity.IntersectionPointId))
                    {
                        counter++;
                        var time = intensity.Time;
                        report.LastDate = time;

                        if (time.Hour == 0 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 0.14);
                        else if (time.Hour == 0 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 0.29);
                        else if (time.Hour == 0 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 0.44);
                        else if (time.Hour == 0 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 0.59);

                        else if (time.Hour == 1 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 1.14);
                        else if (time.Hour == 1 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 1.29);
                        else if (time.Hour == 1 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 1.44);
                        else if (time.Hour == 1 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 1.59);

                        else if (time.Hour == 2 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 2.14);
                        else if (time.Hour == 2 && time.Minute >= 15 && time.Minute < 30)
                            report.SetIntensityOn24hourDic(intensity, report, 2.29);
                        else if (time.Hour == 2 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 2.44);
                        else if (time.Hour == 2 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 2.59);

                        else if (time.Hour == 3 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 3.14);
                        else if (time.Hour == 3 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 3.29);
                        else if (time.Hour == 3 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 3.44);
                        else if (time.Hour == 3 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 3.59);

                        else if (time.Hour == 4 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 4.14);
                        else if (time.Hour == 4 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 4.29);
                        else if (time.Hour == 4 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 4.44);
                        else if (time.Hour == 4 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 4.59);

                        else if (time.Hour == 5 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 5.14);
                        else if (time.Hour == 5 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 5.29);
                        else if (time.Hour == 5 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 5.44);
                        else if (time.Hour == 5 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 5.59);

                        else if (time.Hour == 6 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 6.14);
                        else if (time.Hour == 6 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 6.29);
                        else if (time.Hour == 6 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 6.44);
                        else if (time.Hour == 6 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 6.59);

                        else if (time.Hour == 7 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 7.14);
                        else if (time.Hour == 7 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 7.29);
                        else if (time.Hour == 7 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 7.44);
                        else if (time.Hour == 7 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 7.59);

                        else if (time.Hour == 8 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 8.14);
                        else if (time.Hour == 8 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 8.29);
                        else if (time.Hour == 8 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 8.44);
                        else if (time.Hour == 8 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 8.59);

                        else if (time.Hour == 9 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 9.14);
                        else if (time.Hour == 9 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 9.29);
                        else if (time.Hour == 9 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 9.44);
                        else if (time.Hour == 9 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 9.59);

                        else if (time.Hour == 10 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 10.14);
                        else if (time.Hour == 10 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 10.29);
                        else if (time.Hour == 10 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 10.44);
                        else if (time.Hour == 10 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 10.59);

                        else if (time.Hour == 11 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 11.14);
                        else if (time.Hour == 11 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 11.29);
                        else if (time.Hour == 11 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 11.44);
                        else if (time.Hour == 11 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 11.59);

                        else if (time.Hour == 12 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 12.14);
                        else if (time.Hour == 12 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 12.29);
                        else if (time.Hour == 12 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 12.44);
                        else if (time.Hour == 12 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 12.59);

                        else if (time.Hour == 13 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 13.14);
                        else if (time.Hour == 13 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 13.29);
                        else if (time.Hour == 13 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 13.44);
                        else if (time.Hour == 13 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 13.59);

                        else if (time.Hour == 14 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 14.14);
                        else if (time.Hour == 14 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 14.29);
                        else if (time.Hour == 14 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 14.44);
                        else if (time.Hour == 14 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 14.59);

                        else if (time.Hour == 15 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 15.14);
                        else if (time.Hour == 15 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 15.29);
                        else if (time.Hour == 15 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 15.44);
                        else if (time.Hour == 15 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 15.59);

                        else if (time.Hour == 16 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 16.14);
                        else if (time.Hour == 16 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 16.29);
                        else if (time.Hour == 16 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 16.44);
                        else if (time.Hour == 16 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 16.59);

                        else if (time.Hour == 17 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 17.14);
                        else if (time.Hour == 17 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 17.29);
                        else if (time.Hour == 17 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 17.44);
                        else if (time.Hour == 17 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 17.59);

                        else if (time.Hour == 18 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 18.14);
                        else if (time.Hour == 18 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 18.29);
                        else if (time.Hour == 18 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 18.44);
                        else if (time.Hour == 18 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 18.59);

                        else if (time.Hour == 19 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 19.14);
                        else if (time.Hour == 19 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 19.29);
                        else if (time.Hour == 19 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 19.44);
                        else if (time.Hour == 19 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 19.59);

                        else if (time.Hour == 20 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 20.14);
                        else if (time.Hour == 20 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 20.29);
                        else if (time.Hour == 20 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 20.44);
                        else if (time.Hour == 20 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 20.59);

                        else if (time.Hour == 21 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 21.14);
                        else if (time.Hour == 21 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 21.29);
                        else if (time.Hour == 21 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 21.44);
                        else if (time.Hour == 21 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 21.59);

                        else if (time.Hour == 22 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 22.14);
                        else if (time.Hour == 22 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 22.29);
                        else if (time.Hour == 22 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 22.44);
                        else if (time.Hour == 22 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 22.59);

                        else if (time.Hour == 23 && time.Minute < 15) report.SetIntensityOn24hourDic(intensity, report, 23.14);
                        else if (time.Hour == 23 && time.Minute >= 15 && time.Minute < 30) report.SetIntensityOn24hourDic(intensity, report, 23.29);
                        else if (time.Hour == 23 && time.Minute >= 30 && time.Minute < 45) report.SetIntensityOn24hourDic(intensity, report, 23.44);
                        else if (time.Hour == 23 && time.Minute >= 45 && time.Minute < 60) report.SetIntensityOn24hourDic(intensity, report, 23.59);
                    }
                }
                reports.Add(report);
            }
            Console.WriteLine(counter);
            File.WriteAllText(Constants.filePath + "/report.json", JsonConvert.SerializeObject(reports));
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
