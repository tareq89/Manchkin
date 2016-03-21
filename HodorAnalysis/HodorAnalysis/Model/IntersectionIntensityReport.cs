using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodorAnalysis.Model
{
    public class IntersectionIntensityReport
    {
        public DateTime Date { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int DayOfTheMonth { get; set; }
        public int DayOfTheYear { get; set; }
        public DetailIntersectionPoint DetailedIntersectionPoint { get; set; }
        public Dictionary<double, IntensityInATimeSegment> IntensityOn24hourDic { get; set; }
        public IntersectionIntensityReport()
        {
            IntensityOn24hourDic = new Dictionary<double, IntensityInATimeSegment>();
            IntensityOn24hourDic.Add(0.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(0.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(0.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(0.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(1.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(1.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(1.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(1.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(2.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(2.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(2.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(2.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(3.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(3.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(3.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(3.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(4.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(4.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(4.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(4.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(5.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(5.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(5.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(5.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(6.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(6.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(6.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(6.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(7.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(7.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(7.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(7.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(8.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(8.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(8.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(8.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(9.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(9.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(9.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(9.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(10.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(10.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(10.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(10.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(11.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(11.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(11.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(11.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(12.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(12.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(12.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(12.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(13.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(13.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(13.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(13.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(14.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(14.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(14.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(14.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(15.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(15.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(15.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(15.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(16.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(16.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(16.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(16.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(17.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(17.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(17.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(17.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(18.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(18.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(18.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(18.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(19.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(19.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(19.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(19.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(20.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(20.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(20.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(20.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(21.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(21.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(21.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(21.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(22.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(22.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(22.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(22.59, new IntensityInATimeSegment());

            IntensityOn24hourDic.Add(23.14, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(23.29, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(23.44, new IntensityInATimeSegment());
            IntensityOn24hourDic.Add(23.59, new IntensityInATimeSegment());
        }

        public void SetIntensityOn24hourDic(Intensitys intensity, IntersectionIntensityReport report, double key)
        {
            IntensityInATimeSegment value;
            bool foo = report.IntensityOn24hourDic.TryGetValue(key, out value);
            if (!foo)
            {
                IntensityInATimeSegment intensityInSegment = new IntensityInATimeSegment();
                report.IntensityOn24hourDic[key] = intensityInSegment;
            }
            switch (intensity.Intensity)
            {
                case "High":
                    report.IntensityOn24hourDic[key].TotalHigh++;
                    break;
                case "Medium":
                    report.IntensityOn24hourDic[key].TotalMedium++;
                    break;
                case "Low":
                    report.IntensityOn24hourDic[key].TotalLow++;
                    break;
                default:
                    break;
            }
        }
        public class IntensityInATimeSegment
        {
            public int Average { get; set; }
            public int TotalLow { get; set; }
            public int TotalMedium { get; set; }
            public int TotalHigh { get; set; }
        }

    }
}
