using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoiarkiNet
{
    public class PlantsCollection
    {
        public List<Plants> Collection;

        public PlantsCollection()
        {
            Collection = new List<Plants>()
            {
                new Plants("Ромашка", 100, 50),
                new Plants("Огурец", 100, 50),
                new Plants("Орех", 100, 50)
            };
        }
    }
}
