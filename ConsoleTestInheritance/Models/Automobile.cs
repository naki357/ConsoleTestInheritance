using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToddCorp.GlobalInterfaces;
using System.Device.Location;

namespace ConsoleTestInheritance.Models
{
    internal class Automobile : Vehicle, ITrackLifetimeMovement
    {
        internal Driver Driver { get; set; }
        public float LifetimeMetersMoved { get; set; }
        public float LifetimeSecondsOperated { get; set; }
        public GeoCoordinate GeoCoordinate { get; set; }

        internal Automobile(string name) : base(name) { }

        public override void Move(float metersTraveled, float degrees, float secondsElapsed, float verticalMeters = 0)
        {
            base.Move(metersTraveled, degrees, secondsElapsed, verticalMeters);
            TrackLifetimeMovement(metersTraveled, secondsElapsed);
        }

        public void TrackLifetimeMovement(float metersTraveled, float secondsElapsed)
        {
            LifetimeMetersMoved += metersTraveled;
            LifetimeSecondsOperated += secondsElapsed;
        }

        
    }
}
