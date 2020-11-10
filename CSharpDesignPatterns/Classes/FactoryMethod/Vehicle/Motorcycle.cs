using CSharpDesignPatterns.FactoryMethod.Vehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.FactoryMethod.Vehicle
{
    public class Motorcycle : IVehicle
    {
        public VehicleType VehicleType => VehicleType.Motorcycle;
        public int WheelCount => 2;

        public string GetVehicleType()
        {
            return "Motorcycle";
        }
    }
}
