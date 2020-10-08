using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            car = new Car("Vw", "Polo", 9, 50);

            Assert.IsNotNull(car);
        }

        [TestCase ("BMW")]
        [TestCase("Fiat")]
        [TestCase("Volga")]

        public void TestIfMakeIsValid(string make)
        {
            car = new Car(make, "bestOne", 9, 50);
            var expectedMake = make;
            var actualMake = car.Make;

            Assert.AreEqual(expectedMake, actualMake);
        }

        [TestCase("")]
        [TestCase(null)]
        public void TestIfMakeThrowsException(string make)
        {

            Assert.Throws<ArgumentException>(() =>
            {
               var car = new Car(make, "bestOne", 9, 50);
            });
        }

        [TestCase("A3")]
        [TestCase("A5")]
        [TestCase("R8")]
        public void TestIfModelIsValid(string model)
        {
            car = new Car("Audi", model, 9, 50);
            var expectedModel = model;
            var actualModel = car.Model;

            Assert.AreEqual(expectedModel, actualModel);
        }

        [TestCase("")]
        [TestCase(null)]
        public void TestIfModelThrowsException(string model)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Audi", model, 9, 50);
            });
        }

        [TestCase(9.5)]
        [TestCase(8.1)]
        [TestCase(6)]
        [TestCase(12.8)]
        [TestCase(22.1)]
        public void TestIfFuelConsumtionIsValid(double fconsump)
        {
            car = new Car("Audi", "RS7", fconsump, 50);
            var expectedFuelConsumtion = fconsump;
            var actualFuelConsumption = car.FuelConsumption;

            Assert.AreEqual(expectedFuelConsumtion, actualFuelConsumption);
        }

        [TestCase(0.0)]
        [TestCase(-10.0)]
        [TestCase(-8.2)]
        [TestCase(-15.6)]
        
        public void TestIfFuelConsumptionThrowsException(double fconsump)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                 car = new Car("Audi", "RS7", fconsump, 50);
            });
        }


        [TestCase(0.0)]
        [TestCase(5.0)]

        public void TestIfFuelAmountIsValid(double fuelA)
        {
            car = new Car("Audi", "RS7", 15.2, 50);
            var expectedFuelA = fuelA;
            var actualFuelA = car.FuelAmount;
            
            Assert.IsTrue(actualFuelA <= expectedFuelA);
        }

        //fuelAmountNegativeShouldThrowException

        [TestCase(10)]
        [TestCase(50)]
        [TestCase(80)]
        [TestCase(100)]
        public void TestIfFuelCapacityIsValid(double fCapacity)
        {
            car = new Car("Audi", "RS7", 15.2, fCapacity);
            var expectedCapacity = fCapacity;
            var actualCapacity = car.FuelCapacity;

            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [TestCase(0.0)]
        [TestCase(-25.1)]
        [TestCase(-50)]
        public void TestIfNegativeOrNullFuelCapacityThrowsException(double fCapacity)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("Audi", "RS7", 15.2, fCapacity);
            });
        }

        [TestCase(25)]
        [TestCase(50)]
        [TestCase(60)]
        
        public void TestIfRefuelWorksCorrectly(double fuelToRefuel)
        {
            car = new Car("Audi", "RS7", 15.2, 65);
            
            car.Refuel(fuelToRefuel);
            var expectedFAmount = fuelToRefuel;
            var actualFAmount = car.FuelAmount;
            
            Assert.AreEqual(expectedFAmount, actualFAmount);
        }

        [TestCase(70)]
        [TestCase(85)]
        public void TestIfRefuelAmountIsMoreWorksCorrectly(double fuelRefuel)
        {
            car = new Car("Audi", "RS7", 15.2, 65);
            
            car.Refuel(fuelRefuel);

            Assert.That(car.FuelAmount == car.FuelCapacity);
        }

        [TestCase(0)]
        [TestCase(-10.2)]
        [TestCase(-20)]
        public void TestIfRefuelThrowsException(double fuelRefuel)
        {
             car = new Car("Audi", "RS7", 15.2, 65);

            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelRefuel);
            });
        }

        [TestCase(100.00)]
        [TestCase(200.00)]
        public void TestIfDriveWorksCorrectly(double distanceKm)
        {
            car = new Car("Audi", "RS7", 15.2, 65);

            car.Refuel(50);
            var fuelNeededExp = (distanceKm / 100) * car.FuelConsumption;
            var ExpFuelAmount = car.FuelAmount - fuelNeededExp;
            
            car.Drive(distanceKm);
            var actualAmount = car.FuelAmount;

            Assert.AreEqual(ExpFuelAmount, actualAmount);
        }

        [TestCase(160)]
        [TestCase(250)]
        public void TestIfDriveThrowsException(double distanceKm)
        {
            car = new Car("Audi", "RS7", 15.5, 65);
            car.Refuel(20);

            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(distanceKm);
            });
        }
    }
}