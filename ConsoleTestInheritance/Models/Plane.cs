using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTestInheritance.Models
{
    internal class Plane : Aircraft
    {
        internal int WingAngle { get; set; }

        internal Plane(string name) : base(name) { }
    }
}
