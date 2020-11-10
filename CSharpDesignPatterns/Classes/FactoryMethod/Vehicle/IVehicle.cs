using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.FactoryMethod.Vehicle.Interfaces
{
    public interface IVehicle
    {
        VehicleType VehicleType { get; }
        int WheelCount { get; }

        string GetVehicleType();
    }

    public enum VehicleType
    {
        Car,
        Motorcycle
    }
}
