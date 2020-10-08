namespace BlueOrigin.Tests
{
    using System;
    //using BlueOrigin;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private Spaceship spaceship;
        private Astronaut astronaut;

        

        [Test]
        public void TestIfSpaceshipConstructorWorksCorrectly()
        {
            spaceship = new Spaceship("Austro1", 6);
            string expName = "Austro1";
            int expCapacity = 6;
            string actualName = spaceship.Name;
            int actualCapacity = spaceship.Capacity;

            Assert.AreEqual(expName, actualName);
            Assert.AreEqual(expCapacity, actualCapacity);
        }

        [TestCase("")]
        [TestCase(null)]
        public void TestIfConstructorInvalidNameThrowsException(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                spaceship = new Spaceship(name, 6);
            });
        }

        [TestCase(-2)]
        [TestCase(-10)]
        public void TestIfConstructorInvalidCapacityThrowsException(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                spaceship = new Spaceship("Astro1", capacity);
            });
        }

        [Test]
        public void TestIfCountWorksCorrectly()
        {
            spaceship = new Spaceship("Astro1", 6);
            astronaut = new Astronaut("Pesho", 35.5);
            spaceship.Add(astronaut);

            int expCount = 1;
            int actualCount = spaceship.Count;

            Assert.AreEqual(expCount, actualCount);
        }

        [Test]
        public void TestIfAddThrowsExceptionWhenNoMoreSpace()
        {
            spaceship = new Spaceship("Astro1", 1);
            astronaut = new Astronaut("Pesho", 35.5);
            spaceship.Add(astronaut);

            var secondAstronaut = new Astronaut("Reymond", 50.4);

            Assert.Throws<InvalidOperationException>(() =>
            {
                spaceship.Add(secondAstronaut);
            });

        }

        [Test]
        public void TestIfAddThrowsExceptionWhenAstrIsAlreadyIn()
        {
            spaceship = new Spaceship("Astro1", 6);
            astronaut = new Astronaut("Pesho", 35.5);
            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(() =>
            {
                spaceship.Add(astronaut);
            });
        }

        [Test]
        public void TestIfRemoveWorksCorrectly()
        {
            spaceship = new Spaceship("Astro1", 6);
            astronaut = new Astronaut("Pesho", 35.5);
            spaceship.Add(astronaut);

            Assert.AreEqual(true, spaceship.Remove("Pesho"));
            Assert.AreEqual(false, spaceship.Remove("Gosho"));
        }

    }
}