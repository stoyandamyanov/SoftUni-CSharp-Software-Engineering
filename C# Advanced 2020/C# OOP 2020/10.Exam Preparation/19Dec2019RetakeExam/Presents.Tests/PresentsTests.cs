namespace Presents.Tests
{
    //using Presents.Tests;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class PresentsTests
    {
        private Present present;
        private Bag bag;

        [Test]
        public void TestIfPresentCtorWorksCorrectly()
        {
            string expName = "Ball";
            double expMagic = 110.45;
            present = new Present(expName, expMagic);

            Assert.AreEqual(expName, present.Name);
            Assert.AreEqual(expMagic, present.Magic);
        }

        [Test]
        public void TestIfBagCtorWorksCorrectly()
        {
            bag = new Bag();

            Assert.IsNotNull(bag);
        }

        [Test]
        public void TestIfCreateWorksCorrectly()
        {
            present = new Present("Ball", 124.54);
            bag = new Bag();
            bag.Create(present);

            Assert.AreEqual(present, bag.GetPresent("Ball"));

        }

        [TestCase(null)]
        public void TestIfCreateThrowsArgNullException(Present present)
        {
            bag = new Bag();
            Assert.Throws<ArgumentNullException>(() =>
            {
                bag.Create(present);
            });
        }

        [Test]
        public void TestIfCreateThrowsIOException()
        {
            bag = new Bag();
            present = new Present("Ball", 124.54);
            bag.Create(present);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bag.Create(present);
            });
        }
        [Test]
        public void TestIfRemoveWorksCorrectly()
        {
            bag = new Bag();
            present = new Present("Ball", 124.54);
            bag.Create(present);

            Assert.AreEqual(true, bag.Remove(present));
        }

        [Test]
        public void TestIfGetPresentWithLeastMagicWorksCorrectly()
        {
            bag = new Bag();
            present = new Present("Ball", 124.54);
            var present2 = new Present("Doll", 22.45);
            bag.Create(present);
            bag.Create(present2);

            Assert.AreEqual(present2, bag.GetPresentWithLeastMagic());
        }

        [Test]
        public void TestIfGetPresentWorkCorrectly()
        {
            bag = new Bag();
            present = new Present("Ball", 124.54);
            bag.Create(present);

            Assert.AreEqual(present, bag.GetPresent("Ball"));
        }

        [Test]
        public void TestIfGetPresentsWorksCorrectly()
        {
            bag = new Bag();
            present = new Present("Ball", 124.54);
            var present2 = new Present("Car", 45.20);
            bag.Create(present);
            bag.Create(present2);

            List<Present> ExpPresents = new List<Present>();
            ExpPresents.Add(present);
            ExpPresents.Add(present2);

            Assert.AreEqual(ExpPresents, bag.GetPresents());
        }
    }
}
