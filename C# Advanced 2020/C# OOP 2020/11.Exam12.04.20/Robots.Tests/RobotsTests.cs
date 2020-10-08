namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robots;
        [Test]
        public void TestIfRobotConstructorWorksCorrectly()
        {
            robot = new Robot("Pesho", 100);

            string expName = "Pesho";
            int expMaxBATTERY = 100;

            Assert.AreEqual(expName, robot.Name);
            Assert.AreEqual(expMaxBATTERY, robot.Battery);
            Assert.AreEqual(expMaxBATTERY, robot.Battery);
        }

        [Test]
        public void TestIfRobotManagerCtorWorksCorrectly()
        {
            robots = new RobotManager(10);

            Assert.IsNotNull(robots);
        }

        [Test]
        public void TestIfRobotManagerCapacityThrowsEXP()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                robots = new RobotManager(-10);
            });
        }

        [Test]
        public void TestIfCountWorksCorrectly()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);
            int expCount = 1;

            Assert.AreEqual(expCount, robots.Count);
        }

        [Test]
        public void TestIfAddThrowsIOEException()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robots.Add(robot);
            });
        }

        [Test]
        public void TestIfAddThrowsIOEEXPCapacity()
        {
            robots = new RobotManager(0);
            robot = new Robot("Pesho", 100);


            Assert.Throws<InvalidOperationException>(() =>
            {
                robots.Add(robot);
            });
        }

        [Test]
        public void TestIfRemoveWorks()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);
            robots.Remove("Pesho");

            Assert.AreEqual(0, robots.Count);
        }

        [Test]
        public void TestIfRemoveThrowsException()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robots.Remove("Ganio");
            });
        }

        [Test]
        public void TestWorkisCorrectly()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);

            robots.Work("Pesho", "running", 50);

            Assert.AreEqual(50, robot.Battery);
        }

        [Test]
        public void TestIfWorkThrowsExp()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robots.Work("Gosho", "aaa", 50);
            });
        }

        [Test]
        public void TestIfWorkThrowsEXPBATTERY()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 10);
            robots.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robots.Work("Pesho", "adsd", 50);
            });
        }

        [Test]
        public void TestIfChargeWorksCorrectly()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);
            robots.Work("Pesho", "work", 50);
            robots.Charge("Pesho");

            Assert.AreEqual(100, robot.Battery);
        }

        [Test]
        public void TestIfChargeThrowsExp()
        {
            robots = new RobotManager(10);
            robot = new Robot("Pesho", 100);
            robots.Add(robot);
            robots.Work("Pesho", "work", 50);


            Assert.Throws<InvalidOperationException>(() =>
            {
                robots.Charge("Gosho");
            });
        }
    }
}
