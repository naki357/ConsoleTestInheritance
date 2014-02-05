using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToddCorp.GlobalInterfaces;

namespace ConsoleTestInheritance.Models
{
    internal class Helicopter : Aircraft, ITrackLifetimeMovement
    {
        internal int RotorRPM { get; set; }
        public float LifetimeMetersMoved { get; set; }
        public float LifetimeSecondsOperated { get; set; }

        internal Helicopter(string name) : base(name) { }

        public override void Move(float metersTraveled, float degrees, float secondsElapsed, float verticalMeters = 0)
        {
 	        base.Move(metersTraveled, degrees, secondsElapsed, verticalMeters);
            TrackLifetimeMovement(metersTraveled, secondsElapsed);  // Make sure to fulfill the ITrackLifetimeMovement requirement.
        }

        public void TrackLifetimeMovement(float metersTraveled, float secondsElapsed)
        {
            LifetimeMetersMoved += metersTraveled;
            LifetimeSecondsOperated += secondsElapsed;
        }
    }
}
