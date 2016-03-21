using HodorAnalysis.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodorAnalysis.DB
{
    interface IMongoContext
    {
        IMongoDatabase Database { get; }
        IMongoCollection<IntersectionPoints> IntersectionPoints { get; }
        IMongoCollection<Intersections> Intersections { get; }
        IMongoCollection<Origins> Origins { get; }
        IMongoCollection<Intensitys> Intensitys { get; }
    }
}
