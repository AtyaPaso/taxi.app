using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxiclass taxi = new Taxiclass();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}