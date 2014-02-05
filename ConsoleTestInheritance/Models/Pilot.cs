using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTestInheritance.Models
{
    internal class Pilot : Operator
    {
        internal int PilotID { get; set; }
        internal string PilotsLicense { get; set; }
    }
}
