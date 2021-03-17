﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTaxi
{
    class Taxiclass
    {

        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public int NumPassanger { get; set; }


        public void TaxiInfo()
        {
            Console.WriteLine("Driver name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number Of Passenger : {0}", NumPassanger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
