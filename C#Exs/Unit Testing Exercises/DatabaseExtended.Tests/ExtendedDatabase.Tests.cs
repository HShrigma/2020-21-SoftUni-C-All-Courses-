using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {
            ExtendedDatabase database = new ExtendedDatabase();
            //ExtendedDatabase.Person person = new ExtendedDatabase.Person();
        }

        [Test]
        public void Person_CreateValidPerson()
        {
            Person person = new Person(123, "Test");
            Assert.That(person.Id == 123 && person.UserName == "Test");
        }

        [Test]
        public void Ctor_CreateValidExtendedDatabase()
        {
            List<Person> people = new List<Person>();
            int n = 16;

            for (int i = 0; i < n; i++)
            {
                people.Add(new Person(i, i.ToString()));
            }

            ExtendedDatabase database = new ExtendedDatabase(people.ToArray());

            Assert.That(people.TrueForAll(n => database.FindById(n.Id).Id == n.Id && database.FindByUsername(n.UserName).UserName == n.UserName));
        }

        [Test]
        public void Ctor_ThrowArgumentExceptionWhenDataArrayExceedsLimit()
        {
            Person[] people = new Person[17];

            for (int i = 0; i < 17; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(people));
        }

        [Test]
        public void Add_AddValidMember()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            ExtendedDatabase database = new ExtendedDatabase(people);

            database.Add(new Person(123, "Test"));

            Assert.That(database.Count == 16 && database.FindById(123).Id == 123);
        }

        [Test]
        public void Add_ThrowInvalidOperationExceptionForExceedingLimit()
        {
            Person[] people = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            ExtendedDatabase database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(123, "Test")));
        }

        [Test]
        public void Add_ThrowInvalidOperationExceptionForSameID()
        {
            Person[] people = new Person[14];

            for (int i = 0; i < 14; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            ExtendedDatabase database = new ExtendedDatabase(people);
            database.Add(new Person(123, "Weed"));

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(123, "Test")));
        }

        [Test]
        public void Add_ThrowInvalidOperationExceptionForSameUsername()
        {
            Person[] people = new Person[14];

            for (int i = 0; i < 14; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            ExtendedDatabase database = new ExtendedDatabase(people);
            database.Add(new Person(123, "Test"));

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(1234, "Test")));
        }

        [Test]
        public void Remove_DoValidRemoval()
        {
            Person[] people = new Person[15];

            for (int i = 0; i < 15; i++)
            {
                people[i] = new Person(i, i.ToString());
            }

            ExtendedDatabase database = new ExtendedDatabase(people);
            int count = database.Count;
            database.Remove();

            Assert.That(database.Count == count - 1);
        }

        [Test]
        public void Remove_ThrowInvalidOperationExceptionForNoMembers()
        {
            ExtendedDatabase database = new ExtendedDatabase();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FindByUsername_ThrowsArgumentNullExceptionForEmptyValue()
        {
            Person[] people = new Person[1];
            people[0] = new Person(123, "mangal");
            ExtendedDatabase database = new ExtendedDatabase(people);

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(""));
        }

        [Test]
        public void FindByUsername_ThrowsInvalidOperationExceptionForNoMatch()
        {
            Person[] people = new Person[1];
            people[0] = new Person(123, "mangal");
            ExtendedDatabase database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Tulup"));
        }

        [Test]
        public void FindByID_ThrowsArgumentOutOfRangeExceptionForNegativeNum()
        {
            Person[] people = new Person[1];
            people[0] = new Person(123, "mangal");
            ExtendedDatabase database = new ExtendedDatabase(people);

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-200));
        }

        [Test]
        public void FindByID_ThrowsInvalidOperationExceptionForNoMatch()
        {
            Person[] people = new Person[1];
            people[0] = new Person(123, "mangal");
            ExtendedDatabase database = new ExtendedDatabase(people);

            Assert.Throws<InvalidOperationException>(() => database.FindById(21321));
        }
    }
}