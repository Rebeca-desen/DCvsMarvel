using projectC.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace projectC.Services
{
    public class HeroisServices
    {
        private readonly IMongoCollection<HeroisDCMarvel> _herois;

        public HeroisServices(IHeroistoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _herois = database.GetCollection<HeroisDCMarvel>(settings.HeroisCollectionName);
        }
    }
}