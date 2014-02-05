using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTestInheritance.Models;
using System.Device.Location;

namespace ConsoleTestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertibleAutomobile convertibleAutomobile = new ConvertibleAutomobile("BMW 335Ci");
            convertibleAutomobile.Move(200, 50, 4);
            //convertibleAutomobile.
            convertibleAutomobile.Move(new GeoCoordinate(1.0, 1.0, 500, 1, 1, 250, 100), 100.5F);
            string convertResult = convertibleAutomobile.Convert();

            Plane plane = new Plane("Boeing 747");
            plane.Move(500, 50, 5, 15);
            plane.Move(250, 60, 4, -25);
            
            /* 
            Helicopter helicopter = new Helicopter("US Viper");
            helicopter.Fly(100, 200, 7);
            helicopter.Fly(150, -250, 3);
            */

            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(convertibleAutomobile);
            vehicleList.Add(plane);
            foreach (Vehicle vehicle in vehicleList)
            {
                Console.WriteLine(vehicle.Name + " | Distance Traveled: " + vehicle.TripMeters + 
                    " | Seconds Elapsed: " + vehicle.TripSecondsElapsed + " | End Position: ");
            }
        }
    }
}
