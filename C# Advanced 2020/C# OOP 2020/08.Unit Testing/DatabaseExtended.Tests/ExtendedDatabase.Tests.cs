using ExtendedDatabase;
using NUnit.Framework;
using System;
using System.Reflection;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private Person person;
        private Person person2;


        [SetUp]
        public void Setup()
        {
            person = new Person(213415135, "Pesho");
            person2 = new Person(123131241, "Gosho");
        }

        [Test]
        public void TestIfConstructorWorkCorrectly()
        {
            var persons = new Person[] { person, person2 };

            var database = new ExtendedDatabase.ExtendedDatabase(persons);
            var expectedCount = persons.Length;
            var actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        [TestCase(17)]
        [TestCase(18)]
        [TestCase(22)]
        [TestCase(555)]
        [TestCase(100)]
        [TestCase(1000)]
        public void AddRange_Throws_ArgumentException_WhenCountMoreThan16(int count)
        {
            Person[] data = new Person[count];
            Assert.Throws<ArgumentException>(() =>
            {
                new ExtendedDatabase.ExtendedDatabase(data);
            });
        }

        [Test]
        public void TestIfConstructorThrowException()
        {
            var persons = new Person[17];

            Assert.Throws<ArgumentException>(() =>
            {
                var data = new ExtendedDatabase.ExtendedDatabase(persons);
            });
        }



        [Test]
        [TestCase(14321, "Pesho")]
        [TestCase(441324, "Ivana")]
        [TestCase(95439, "Simona")]
        [TestCase(444213, "Rayna")]
        [TestCase(111432, "Vladi")]
        public void Person_SuccessfulDataPass(long id, string userName)
        {
            Person person = new Person(id, userName);
            long expectedId = id;
            long actualId = person.Id;
            string expectedUsername = userName;
            string actualUsername = person.UserName;

            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedUsername, actualUsername);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(16)]
        public void ExtendedDB_Constructor_CorrectAmountOfData(int count)
        {
            Person[] people = new Person[count];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, "Ivan" + i);
            }

            ExtendedDatabase.ExtendedDatabase extDb = new ExtendedDatabase.ExtendedDatabase(people);

            int expected = people.Length;
            int actual = extDb.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConstructorPersonShouldInitializeCollection()
        {
            Assert.IsNotNull(person);
        }
        [Test]
        public void ConstructorExtendedDBShouldInitializeCollection()
        {
            var expected = new Person[] { person, person2 };

            var db = new ExtendedDatabase.ExtendedDatabase(expected);

            Assert.IsNotNull(db);
        }

        [Test]
        public void TestIfAddWorksCorrectly()
        {
            var persontoADD = person;
            var data = new ExtendedDatabase.ExtendedDatabase();

            data.Add(persontoADD);

            Assert.That(data.Count == 1);
        }

        [TestCase(13)]
        [TestCase(15)]
        [TestCase(14)]
        [TestCase(7)]
        [TestCase(1)]
        public void Add_WorksCorrectly_WhenCountIsLessThan16(int count)
        {
            Person[] people = new Person[count];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, "Peter" + i);
            }

            ExtendedDatabase.ExtendedDatabase extDb = new ExtendedDatabase.ExtendedDatabase(people);

            extDb.Add(new Person(200, "Peter" + 200));

            int expected = people.Length + 1;
            int actual = extDb.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(16)]
        public void Add_Throws_InvalidOperationException_WhenCountIs16(int count)
        {
            Person[] people = new Person[count];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, "Ivan" + i);
            }
            ExtendedDatabase.ExtendedDatabase extDb = new ExtendedDatabase.ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>
                (() => extDb.Add(new Person(200, "Ivan" + 200)));

        }

        [Test]
        public void TestIfAddExistingUsernameThrowException()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);
            var newPerson = new Person(213415135, "Pesho");

            Assert.That(() => db.Add(newPerson), Throws.InvalidOperationException);
        }

        [Test]
        public void TestIfAddExistingIdThrowException()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);
            var newPerson = new Person(213415135, "Dragan");

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(newPerson);
            });
        }

        [Test]
        public void TestIfRemoveisValid()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);
            db.Remove();
            var actualCounter = db.Count;

            Assert.That(actualCounter == 1);
        }

        [Test]
        public void TestIfRemoveThrowException()
        {
            var persons = new Person[] { };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Remove();
            });
        }

        [Test]
        public void TestFindByUsernameValid()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);
            var validUser = db.FindByUsername("Pesho");

            Assert.That(validUser.UserName == "Pesho");
        }

        [TestCase("A")]
        [TestCase("Genadi")]

        public void TestFindByUsernameInvalid(string name)
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindByUsername(name);
            });
        }

        [Test]
        public void TestFindByNullUsernameThrowException()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);
            var usernameToFind = new Person(214135, null);
            Assert.Throws<ArgumentNullException>(() =>
            {
                db.FindByUsername(usernameToFind.UserName);
            });
        }

        [Test]
        public void FindByUsernameIsCaseSensitive()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);

            Assert.That(() => db.FindByUsername("GOSHO"), Throws.InvalidOperationException);
        }

        [Test]
        public void TestFindByIdValid()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);
            var validUser = db.FindById(213415135);

            Assert.That(validUser.Id == 213415135);
        }

        [TestCase(696969)]
        [TestCase(0)]
        public void TestFindByIdInvalid(int id)
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);

            Assert.Throws<InvalidOperationException>(() =>
            {
                db.FindById(id);
            });
        }

        [Test]
        public void TestFindByNegativeIdThrowException()
        {
            var persons = new Person[] { person, person2 };
            var db = new ExtendedDatabase.ExtendedDatabase(persons);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                db.FindById(-1);
            });
        }
    }
}