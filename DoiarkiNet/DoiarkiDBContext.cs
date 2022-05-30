using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoiarkiNet
{
    public class DoiarkiDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public DoiarkiDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("DoiarkiDB");
        }
        public List<Animal> Animal
        {
            get
            {
                var item =  _mongoDatabase.GetCollection<Animal>("Animal");
                return item.Find(new BsonDocument()).ToList();
            }
        }
        public List<Plants> Plants
        {
            get
            {
                var item = _mongoDatabase.GetCollection<Plants>("Plants");
                return item.Find(new BsonDocument()).ToList();
            }
        }
    }
}
