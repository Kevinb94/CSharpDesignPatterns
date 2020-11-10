using CSharpDesignPatterns.FactoryMethod.Vehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.FactoryMethod.Vehicle
{
    public class VehicleFactory
    {
        public IVehicle Create(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Motorcycle:
                    return new Motorcycle();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
