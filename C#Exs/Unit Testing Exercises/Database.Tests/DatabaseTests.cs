using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            database = new Database();
        }
        [Test]
        public void Ctor_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }

        [Test]
        public void Fetch_ReturnsArray()
        {
            database = new Database(1, 2, 3);
            int[] items = new int[3] { 1, 2, 3 };
            Assert.That(database.Fetch()[0] == items[0] && database.Fetch()[1] == items[1] && database.Fetch()[2] == items[2]);
        }
        
        [Test]
        public void Fetch_ReturnsElementsNotReference()
        {
            database = new Database(1, 2, 3);
            var first = database.Fetch();
            database.Remove();
            var second = database.Fetch();
            Assert.That(first, Is.Not.EqualTo(second));
        }
        [Test]
        public void Ctor_AddsValidItems()
        {
            int[] items = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            database = new Database(items);

            Assert.That(database.Count, Is.EqualTo(items.Length));
        }

        [Test]
        public void Add_AddsValidElement()
        {
            int[] items = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            database = new Database(items);

            database.Add(16);

            Assert.That(database.Count == 16);
        }

        [Test]
        public void Add_ThrowsInvalidOperationException()
        {
            int[] items = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,16 };

            database = new Database(items);
            Assert.Throws<InvalidOperationException>(() => database.Add(20));
        }
        
        [Test]
        public void Remove_RemovesFromValidDatabase()
        {
            int[] items = new int[3] { 15, 16, 17 };
            int[] removedItems = new int[2] { 15, 16 };

            database = new Database(items);
            database.Remove();
            Assert.That(database.Count == removedItems.Length);
        }

        [Test]
        public void Remove_ThrowsInvalidOperationException()
        {
            int[] items = new int[1] { 5 };
            database = new Database(items);
            database.Remove();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Db_ReturnsZeroWhenEmpty()
        {
            Assert.That(database.Count == 0);
        }
    }
}