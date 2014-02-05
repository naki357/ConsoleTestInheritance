using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTestInheritance.Models
{
    internal class Driver : Operator
    {
        internal int DriverID { get; set; }
        internal string DriversLicense { get; set; }
        internal bool HasCDL { get; set; }
    }
}
