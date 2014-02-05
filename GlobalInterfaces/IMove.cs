using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;

namespace ToddCorp.GlobalInterfaces
{
    public interface IMove
    {
        float TripMeters { get; set; }
        float TripSecondsElapsed { get; set; }
        GeoCoordinate GeoCoordinate { get; set; }

        void Move(float metersTraveled, float degrees, float secondsElapsed, float altitudeChangeMeters = 0);
        double Move(GeoCoordinate geoCoordinate, float secondsElapsed);
    }
}
