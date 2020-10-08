namespace Computers.Tests
{
    using NUnit.Framework;
    using System;

    public class ComputerTests
    {
        private Part part;
        private Computer computer;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfPartConstructorWorksCorrecty()
        {
            part = new Part("Motherboard", 250);

            Assert.IsNotNull(part);
      
        }

        [Test]
        public void TestIfComputerCtorWorksCorrectly()
        {
            computer = new Computer("AsusRog");

            Assert.IsNotNull(computer);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TestIfInvalidNameThrowsException(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                computer = new Computer(name);
            });
        }

        [Test]
        public void TestIfTotalPartsSumWorksCorrectly()
        {
            part = new Part("Motherboard", 250);
            computer = new Computer("LenoovoLegion");
            computer.AddPart(part);
            var totalPrice = computer.TotalPrice;
            var expPrice = 250;

            Assert.AreEqual(expPrice, totalPrice);
            
        }

        [Test]
        public void TestIfAddPartThrowsException()
        {
            part = null;
            computer = new Computer("LenoovoLegion");

            Assert.Throws<InvalidOperationException>(() =>
            {
                computer.AddPart(part);
            });
        }

        [Test]
        public void TestIfRemoveWorksCorrectly()
        {
            part = new Part("Motherboard", 250);
            computer = new Computer("LenoovoLegion");
            computer.AddPart(part);

            Assert.AreEqual(true, computer.RemovePart(part));
        }

        [Test]
        public void TestIfGetPartWorksCorrectly()
        {
            part = new Part("Motherboard", 250);
            computer = new Computer("LenoovoLegion");
            computer.AddPart(part);
            var expPart = new Part("Motherboard", 250);
            var actualPart = computer.GetPart("Motherboard");

            Assert.AreEqual(expPart.Name, actualPart.Name);
            Assert.AreEqual(expPart.Price, actualPart.Price);
        }
    }
}