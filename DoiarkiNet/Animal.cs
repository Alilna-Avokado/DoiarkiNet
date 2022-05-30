using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DoiarkiNet
{
    [DataContract]
    public class Animal
    {
        public Animal(string name, int count, int price)
        {
            ID = Guid.NewGuid().ToString();

            Name = name;
            Count = count;
            Price = price;
        }

        [BsonId]
        [DataMember]
        public string ID { get;  }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public int Price { get; set; }
    }
}
