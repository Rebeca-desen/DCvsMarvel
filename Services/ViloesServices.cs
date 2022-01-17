
using projectC.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace projectC.Services
{
    public class ViloesServices
    {
        
        private readonly IMongoCollection<Viloes> _viloes;

        public ViloesServices(IViloestoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _viloes = database.GetCollection<Viloes>(settings.ViloesCollectionName);
        }

        public List<Viloes> Get() =>
            _viloes.Find(vilao => true).ToList();

       public Viloes Get(string id) =>
            _viloes.Find<Viloes>(vilao => vilao.Id == id).FirstOrDefault();

        public Viloes Create(Viloes vilao)
        {
            _viloes.InsertOne(vilao);
            return vilao;
        }

        public void Update(string id, Viloes viloesIn) =>
            _viloes.ReplaceOne(vilao => vilao.Id == id, viloesIn);

        public void Remove(Viloes viloesIn) =>
            _viloes.DeleteOne(vilao => vilao.Id == viloesIn.Id);

        public void Remove(string id) => 
            _viloes.DeleteOne(vilao => vilao.Id == id);
    }
}