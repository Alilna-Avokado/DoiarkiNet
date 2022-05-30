using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoiarkiNet
{
    public class AnimalCollection
    {
        public List<Animal> Collection;

        public AnimalCollection()
        {
            Collection = new List<Animal>()
            {
                new Animal("Корова", 115, 90000),
                new Animal("Овца", 150, 50000),
                new Animal("Свинья", 125, 40000)
            };
        }
    }
}
