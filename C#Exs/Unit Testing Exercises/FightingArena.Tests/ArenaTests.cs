using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
            Arena arena = new Arena();
        }

        [Test]
        public void Ctor_CreateValidArena()
        {
            Arena arena = new Arena();
            Assert.That(arena.Count == 0);
        }
        
        [Test]
        public void Enroll_EnrollValidWarrior()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 30, 40);
            arena.Enroll(warrior);
            Assert.That(arena.Count == 1);
        }
        
        [Test]
        public void Enroll_EnrollValidWarriors()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 30, 40);
            Warrior warrior1 = new Warrior("Musho", 30, 40);
            arena.Enroll(warrior);
            arena.Enroll(warrior1);
            Assert.That(arena.Count == 2);
        }
        
        [Test]
        public void Enroll_ThrowInvalidOperationExceptionSameName()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 30, 40);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void Fight_ValidFight()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 30, 40);
            arena.Enroll(warrior);
            Warrior warrior1 = new Warrior("Pesho", 30, 40);
            arena.Enroll(warrior1);
            arena.Fight("Gosho", "Pesho");
            Assert.That(arena.Warriors.Count == 2);
        }
        
        [Test]
        public void Fight_ValidFightWithKill()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 80, 40);
            arena.Enroll(warrior);
            Warrior warrior1 = new Warrior("Pesho", 30, 40);
            arena.Enroll(warrior1);
            arena.Fight("Gosho", "Pesho");
            Assert.That(arena.Warriors.FirstOrDefault(n => n.Name == "Pesho").HP == 0);
        }
        
        [Test]
        public void Fight_ThrowInvalidOperationExceptionNullAttacker()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 80, 40);
            arena.Enroll(warrior);
            Warrior warrior1 = new Warrior("Pesho", 30, 40);
            arena.Enroll(warrior1);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Misho", "Gosho"));
        }
        
        [Test]
        public void Fight_ThrowInvalidOperationExceptionNullDefender()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Gosho", 80, 40);
            arena.Enroll(warrior);
            Warrior warrior1 = new Warrior("Pesho", 30, 40);
            arena.Enroll(warrior1);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Pesho", "Gosho12"));
        }
        
        [Test]
        public void Fight_ThrowInvalidOperationExceptionNullWarriors()
        {
            Arena arena = new Arena();
            Assert.Throws<InvalidOperationException>(() => arena.Fight("as", "bas"));
        }
    }
}
