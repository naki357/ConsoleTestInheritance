using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTestInheritance.GlobalHelpers;
using ToddCorp.GlobalInterfaces;

namespace ConsoleTestInheritance.Models
{
    internal abstract class Aircraft : Vehicle
    {
        internal int AircraftID { get; set; }
        int FlightHours { get; set; }
        internal float AltitudeMeters { get; set; }
        internal Pilot Pilot { get; set; }

        internal Aircraft(string name) : base(name) { }
    }
}
