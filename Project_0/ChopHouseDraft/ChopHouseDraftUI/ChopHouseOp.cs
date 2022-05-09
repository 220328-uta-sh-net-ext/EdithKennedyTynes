using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHDL;
using CHModel;

namespace ChopHouseDraftUI
{
    class ChopHouseOp
    {
        
        readonly IRepository repository;

        public ChopHouseOp(IRepository repository)
        {
            this.repository = repository;
        }

        public void GetRestaurants()
        {
            List<ChopHouse>? restaurants = repository.GetRestaurants("name", "s");
            foreach (ChopHouse? rest in restaurants)
            {
                Console.WriteLine(rest);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }

    }
}
