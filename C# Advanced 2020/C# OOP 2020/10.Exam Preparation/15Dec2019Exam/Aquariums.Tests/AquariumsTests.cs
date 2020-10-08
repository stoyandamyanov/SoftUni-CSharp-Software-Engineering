using Aquariums.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aquariums.Tests
{

    public class AquariumsTests
    {
        private Aquarium aquarium;
        private Fish fish;

        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            string name = "TheBigOne";
            int capacity = 20;
            aquarium = new Aquarium(name, capacity);

            Assert.IsNotNull(aquarium);
        }

        [TestCase("")]
        [TestCase(null)]
        public void TestIfConstructorThrowsException(string name)
        {
            int capacity = 20;

            Assert.Throws<ArgumentNullException>(() =>
            {
                aquarium = new Aquarium(name, capacity);
            });
        }

        [TestCase(-5)]
        [TestCase(-10)]
        public void TestIfInvalidCapacityThrowsException(int capacity)
        {
            string name = "GoldOne";

            Assert.Throws<ArgumentException>(() =>
            {
                aquarium = new Aquarium(name, capacity);
            });
        }

        [Test]
        public void TestIfConstructorInfoIsCorrect()
        {
            string name = "TheBigOne";
            int capacity = 20;
            aquarium = new Aquarium(name, capacity);

            string actualName = aquarium.Name;
            int actualCapacity = aquarium.Capacity;

            Assert.AreEqual(name, actualName);
            Assert.AreEqual(capacity, actualCapacity);
        }

        [Test]
        public void TestIfAddWorksCorrectly()
        {
            string name = "TheBigOne";
            int capacity = 10;
            aquarium = new Aquarium(name, capacity);

            fish = new Fish("Pencheto");
            int expCount = 1;
            aquarium.Add(fish);

            Assert.AreEqual(expCount, aquarium.Count);
        }

        [Test]
        public void TestIfAddThrowsException()
        {
            aquarium = new Aquarium("New", 0);

            fish = new Fish("Pencheto");

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.Add(fish);
            });
        }

        [Test]
        public void TestIfRemoveWorksCorrectly()
        {
            aquarium = new Aquarium("NewOne", 2);
            fish = new Fish("Dancho");
            aquarium.Add(fish);

            aquarium.RemoveFish(fish.Name);

            Assert.AreEqual(0, aquarium.Count);
        }

        [Test]
        public void TestIfRemoveThrowsException()
        {
            aquarium = new Aquarium("Test", 1);
            fish = new Fish("Petko");
            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.RemoveFish("Test");
            });
        }

        [Test]
        public void TestIfSellWorksCorrectly()
        {
            aquarium = new Aquarium("Test", 2);
            fish = new Fish("Petko");
            Fish fish2 = new Fish("Aya");
            
            aquarium.Add(fish);
            aquarium.Add(fish2);

            var selledFish = aquarium.SellFish(fish2.Name);

            Assert.AreEqual(false, fish2.Available);
            Assert.AreEqual(selledFish.Name, fish2.Name);
        }

        [Test]
        public void TestIfSellThrowsException()
        {
            aquarium = new Aquarium("Test", 0);
            fish = new Fish("TheBig");

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.SellFish(fish.Name);
            });
        }

        [Test]
        public void TestIfReportWorksCorrectly()
        {
            aquarium = new Aquarium("NewOne", 10);
            fish = new Fish("Dancho");
            aquarium.Add(fish);
            Fish secondfish = new Fish("Gancho");
            aquarium.Add(secondfish);

            string expReport = $"Fish available at {aquarium.Name}: {"Dancho, Gancho"}";

            Assert.AreEqual(expReport, aquarium.Report());
        }
    }
}
