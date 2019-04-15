using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile automobile = new Automobile()
            {
                Name = "RAV4"
            };
            Bus bus = new Bus()
            {
                Name = "ANKAI"
            };
            Sportmobile sportMobile = new Sportmobile()
            {
                Name = "Porshe Cayenne"
            };
            automobile.StartRide();
            bus.StartRide();
            sportMobile.StartRide();
            Console.ReadLine();
        }
    }
    }
}
