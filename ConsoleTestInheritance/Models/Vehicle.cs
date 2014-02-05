using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToddCorp.GlobalInterfaces;
using System.Device.Location;

namespace ConsoleTestInheritance.Models
{
    internal abstract class Vehicle : IMove
    {
        internal string Name { get; set; }
        internal ushort Axles { get; set; }
        internal ushort Doors { get; set; }
        internal Manufacturer Manufacturer { get; set; }
        public float TripMeters { get; set; }
        public float TripSecondsElapsed { get; set; }
        internal ushort MaxPassengers { get; set; }
        internal int MaxHorizMetersPerSecond { get; set; }
        internal int MaxVertMetersPerSecond { get; set; }
        internal float HorizMetersPerSecond { get; set; }
        internal float VertMetersPerSecond { get; set; }
        internal Material ChassisMaterial { get; set; }
        private GeoCoordinate _GeoCoordinate = new GeoCoordinate(0.0D, 0.0D);
        GeoCoordinate IMove.GeoCoordinate 
        {
            get { return _GeoCoordinate; }
            set { _GeoCoordinate = value; }
        }

        internal Vehicle(string name)
        {
            Name = name;
        }

        public virtual void Move(float metersTraveled, float degrees, float secondsElapsed, float verticalMeters = 0)
        {
            TripMeters += metersTraveled;
            TripSecondsElapsed += secondsElapsed;
            _GeoCoordinate.Altitude += verticalMeters;
        }

        public virtual double Move(GeoCoordinate geoCoordinate, float secondsElapsed)
        {
            float metersTraveled = (float)this._GeoCoordinate.GetDistanceTo(geoCoordinate);
            float degrees = (float)this._GeoCoordinate.Course;
            float verticalMeters = (float)this._GeoCoordinate.Altitude - (float)geoCoordinate.Altitude;
            Move(metersTraveled, degrees, secondsElapsed, verticalMeters);

            return metersTraveled;
        }
    }
}
