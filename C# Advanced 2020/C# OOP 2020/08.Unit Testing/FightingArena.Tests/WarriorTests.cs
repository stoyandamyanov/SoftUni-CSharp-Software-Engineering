//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            string expName = "Gosho";
            int expDmg = 50;
            int expHP = 100;

            Warrior warrior = new Warrior(expName, expDmg, expHP);

            Assert.AreEqual(expName, warrior.Name);
            Assert.AreEqual(expDmg, warrior.Damage);
            Assert.AreEqual(expHP, warrior.HP);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void TestIfNameIsNullThrowsException(string name)
        {
            
            int dmg = 50;
            int hp = 100;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp);
            });
        }

        [TestCase(0)]
        [TestCase(-20)]
        public void TestLikeWithZeroOrNegativeDamageThrowsException(int damage)
        {
            string name = "Pesho";
            int hp = 100;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, damage, hp);
            });
        }

        [TestCase(-5)]
        [TestCase(-50)]
        public void TestLikeNegativeHPThrowsException(int hp)
        {
            string name = "Pesho";
            int damage = 50;

            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, damage, hp);
            });
        }

        [Test]
        public void TestIfAttackWorksCorrectly()
        {
            Warrior offenWarrior = new Warrior("Pesho", 40, 100);
            Warrior deffenceWarrior = new Warrior("Gosho", 30, 80);

            var attackerHP = 70;
            var defenderHP = 40;
            offenWarrior.Attack(deffenceWarrior);

            Assert.AreEqual(attackerHP, offenWarrior.HP);
            Assert.AreEqual(defenderHP, deffenceWarrior.HP);
            
        }

        [TestCase(30)]
        [TestCase(15)]
        public void TestIfAttackWithLowHPThrowsException(int HP)
        {
            Warrior offenWarrior = new Warrior("Pesho", 40, HP);
            Warrior deffenceWarrior = new Warrior("Gosho", 30, 80);

            Assert.Throws<InvalidOperationException>(() =>
            {
                offenWarrior.Attack(deffenceWarrior);
            });
        }

        [TestCase(30)]
        [TestCase(1)]
        public void TestIfAttackEnemyWithLowHPThrowException(int hp)
        {
            Warrior offenWarrior = new Warrior("Pesho", 40, 100);
            Warrior deffenceWarrior = new Warrior("Gosho", 30, hp);

            Assert.Throws<InvalidOperationException>(() =>
            {
                offenWarrior.Attack(deffenceWarrior);
            });
        }

        [TestCase(51)]
        [TestCase(60)]
        public void TestIfAttackEnemyWithHigherDamageThrowException(int damage)
        {
            Warrior offenWarrior = new Warrior("Pesho", 40, 50);
            Warrior deffenceWarrior = new Warrior("Gosho", damage, 30);

            Assert.Throws<InvalidOperationException>(() =>
            {
                offenWarrior.Attack(deffenceWarrior);
            });
        }

        [Test]
        public void TestIfAttackWithHigherDamageThanWarriorHPWorksCorrectly()
        {
            Warrior offenWarrior = new Warrior("Pesho", 50, 100);
            Warrior deffenceWarrior = new Warrior("Gosho", 30, 40);
            int deffWarExpHP = 0;
            offenWarrior.Attack(deffenceWarrior);

            Assert.AreEqual(deffWarExpHP, deffenceWarrior.HP);
        }
    }
}