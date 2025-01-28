﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.ISP
{
    internal class Sphere : IShape3D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
