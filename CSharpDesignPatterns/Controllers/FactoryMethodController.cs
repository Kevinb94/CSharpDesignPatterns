using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CSharpDesignPatterns.FactoryMethod.Vehicle.Interfaces;
using CSharpDesignPatterns.FactoryMethod.Vehicle;

namespace CSharpDesignPatterns.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactoryMethodController : ControllerBase
    {
        private VehicleFactory _vehicleFactory;

        [HttpGet]
        public IActionResult GetCar()
        {

            _vehicleFactory = new VehicleFactory();
            IVehicle car = _vehicleFactory.Create(VehicleType.Car);

            string vehicleType = car.GetVehicleType();

            return Ok(vehicleType);
        }

        [HttpGet]
        public IActionResult GetMotorcycle()
        {

            _vehicleFactory = new VehicleFactory();
            IVehicle motorcycle = _vehicleFactory.Create(VehicleType.Motorcycle);

            string vehicleType = motorcycle.GetVehicleType();

            return Ok(vehicleType);


        }
    }
}
