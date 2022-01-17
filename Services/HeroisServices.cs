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

        public List<HeroisDCMarvel> Get() =>
            _herois.Find(heroi => true).ToList();

       public HeroisDCMarvel Get(string id) =>
            _herois.Find<HeroisDCMarvel>(heroi => heroi.Id == id).FirstOrDefault();

        public HeroisDCMarvel Create(HeroisDCMarvel heroi)
        {
            _herois.InsertOne(heroi);
            return heroi;
        }

        public void Update(string id, HeroisDCMarvel heroisIn) =>
            _herois.ReplaceOne(heroi => heroi.Id == id, heroisIn);

        public void Remove(HeroisDCMarvel heroisIn) =>
            _herois.DeleteOne(heroi => heroi.Id == heroisIn.Id);

        public void Remove(string id) => 
            _herois.DeleteOne(heroi => heroi.Id == id);
    }
}
    
