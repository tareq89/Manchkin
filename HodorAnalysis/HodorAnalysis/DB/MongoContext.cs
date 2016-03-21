using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HodorAnalysis.Model;
using System.IO;

namespace HodorAnalysis.DB
{
    class MongoContext : IMongoContext
    {
        private MongoClient _mongoClient;

        public IMongoDatabase Database
        {
            get;
            private set;
        }

        private IMongoCollection<IntersectionPoints> _intersectionPoints;
        public IMongoCollection<IntersectionPoints> IntersectionPoints
        {
            get { return _intersectionPoints; }
            
        }

        private IMongoCollection<Intersections> _intersections;
        public IMongoCollection<Intersections> Intersections
        {
            get { return _intersections; }
        }

        private IMongoCollection<Origins> _origins;
        public IMongoCollection<Origins> Origins
        {
            get { return _origins; }
        }

        private IMongoCollection<Intensitys> _intensitys;
        public IMongoCollection<Intensitys> Intensitys
        {
            get { return _intensitys; }
        }

        public MongoContext()
        {
            var connectionString = File.ReadAllText(@"C:\Users\Zarvis\Documents\Visual Studio 2015\Projects\Manchkin\HodorAnalysis\jsonData\databaseConnectionString.txt");
            var mongoUrlBuilder = new MongoUrlBuilder(connectionString);
            _mongoClient = new MongoClient(mongoUrlBuilder.ToMongoUrl());
            Database = _mongoClient.GetDatabase(mongoUrlBuilder.DatabaseName);

            _intersectionPoints = Database.GetCollection<IntersectionPoints>(CollectionNames.IntersectionPointsCollectionName);
            _intersections = Database.GetCollection<Intersections>(CollectionNames.IntersectionsCollectionName);
            _origins = Database.GetCollection<Origins>(CollectionNames.OriginsCollectionName);
            _intensitys = Database.GetCollection<Intensitys>(CollectionNames.IntensitysCollectionName);
        }
    }
}
