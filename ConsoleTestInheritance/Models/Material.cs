using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTestInheritance.Models
{
    internal class Material
    {
        internal string Name { get; set; }
        internal int TensileStrength { get; set; }
        internal Manufacturer Manufacturer { get; set; }
    }
}
