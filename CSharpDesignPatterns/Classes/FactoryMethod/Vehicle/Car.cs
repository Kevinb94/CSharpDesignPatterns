using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CSharpDesignPatterns.FactoryMethod.Vehicle.Interfaces;

namespace CSharpDesignPatterns.FactoryMethod.Vehicle
{
    public class Car : IVehicle
    {
        public VehicleType VehicleType => VehicleType.Car;
        public int WheelCount => 4;

        public string GetVehicleType()
        {
            Debug.WriteLine("Car");
            return "Car";
        }
    }
}
