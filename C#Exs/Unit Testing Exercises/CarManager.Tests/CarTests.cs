using NUnit.Framework;
using System;
namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_CreateValidCar()
        {
            Car car = new Car("Vw", "Beetle", 1.5, 200);

            Assert.That(car.Make == "Vw" && car.Model == "Beetle" && car.FuelConsumption == 1.5 && car.FuelCapacity == 200);
        }
        
        [Test]
        public void Ctor_ThrowArgumentExceptionMake()
        {
            Assert.Throws<ArgumentException>(() => new Car("", "anus", 1.5, 200));
        }
        
        [Test]
        public void Ctor_ThrowArgumentExceptionModel()
        {
            Assert.Throws<ArgumentException>(() => new Car("vw", "", 1.5, 200));
        }
        
        [Test]
        public void Ctor_ThrowArgumentExceptionFuelConsumption()
        {
            Assert.Throws<ArgumentException>(() => new Car("vw", "anus", -2, 200));
        }
        
        [Test]
        public void Ctor_ThrowArgumentExceptionFuelCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Car("vw", "anus", 2, -200));
        }

        [Test]
        public void Refuel_ThrowArgumentExceptionZeroOrNegative()
        {
            Car car = new Car("Vw", "Beetle", 1.5, 200);
            Assert.Throws<ArgumentException>(() => car.Refuel(0));
        }
        
        [Test]
        public void Refuel_ValidRefuel()
        {
            Car car = new Car("Vw", "Beetle", 1.5, 200);
            car.Refuel(80);
            Assert.That(car.FuelAmount == 80);
        }
        
        [Test]
        public void Drive_ThrowInvalidOperationExceptionNotEnoughFuel()
        {
            Car car = new Car("Vw", "Beetle", 200, 200);
            car.Refuel(80);
            Assert.Throws<InvalidOperationException>(() => car.Drive(500));
        }
        
        [Test]
        public void Drive_ValidDrive()
        {
            Car car = new Car("Vw", "Beetle", 1, 200);
            car.Refuel(80);
            car.Drive(5);
            Assert.That(car.FuelAmount >= 0);
        }


    }
}