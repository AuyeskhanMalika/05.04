﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._04
{
    class Automobile : Car
    {
        public string Name { get; set; }
        public void StartRide()
        {
            Start(Name, Speed(new Random(), 500, 900));
        }
    }
}
