using FightingArena;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {

            Assert.IsNotNull(this.arena.Warriors);
            
        }

        [Test]
        public void TestIfEnrollWorksCorrectly()
        {
            Warrior w1 = new Warrior("Pesho", 50, 100);
            Warrior w2 = new Warrior("Gosho", 30, 40);

            arena.Enroll(w1);
            arena.Enroll(w2);

            
            Assert.That(this.arena.Warriors, Has.Member(w1));
            Assert.That(this.arena.Warriors, Has.Member(w2));
        }

        [Test]
        public void TestIfEnrollThrowException()
        {
            Warrior w1 = new Warrior("Pesho", 50, 100);
            
            arena.Enroll(w1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(w1);
            });
        }

        [Test]
        public void TestIfEnrollThrowExceptionWithnewObj()
        {
            Warrior w1 = new Warrior("Pesho", 50, 100);

            arena.Enroll(w1);
            Warrior w2 = new Warrior("Pesho", 70, 100);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(w2);
            });
        }

        [Test]
        public void TestIfFightWorksCorrectly()
        {
            Warrior w1 = new Warrior("Pesho", 50, 100);
            Warrior w2 = new Warrior("Gosho", 30, 40);

            arena.Enroll(w1);
            arena.Enroll(w2);

            arena.Fight("Pesho", "Gosho");

            Assert.AreEqual(0, w2.HP);

        }

        [Test]
        public void TestIfFightThrowsExceptionWhenAttackerInvalid()
        {
            Warrior w1 = new Warrior("Pesho", 50, 100);
            Warrior w2 = new Warrior("Gosho", 30, 40);

            arena.Enroll(w1);
            arena.Enroll(w2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("Traicho", "Gosho");
            });
        }

        [Test]
        public void TestIfFightThrowsExceptionWhenDeffenderInvalid()
        {
            Warrior w1 = new Warrior("Pesho", 50, 100);
            Warrior w2 = new Warrior("Gosho", 30, 40);

            arena.Enroll(w1);
            arena.Enroll(w2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight("Pesho", "Ivan");
            });
        }
    }
}
