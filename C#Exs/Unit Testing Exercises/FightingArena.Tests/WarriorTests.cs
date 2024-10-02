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
        public void Ctor_ValidWarrior()
        {
            Warrior warrior = new Warrior("Pesho", 10, 500);
            Assert.That(warrior.Name == "Pesho" && warrior.Damage == 10 && warrior.HP == 500);
        }
        
        [Test]
        public void Ctor_NameThrowArgumentExceptionNull()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(null, 5, 10));
        }
        
        [Test]
        public void Ctor_NameThrowArgumentExceptionEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(string.Empty, 5, 10));
        }
        
        [Test]
        public void Ctor_NameThrowArgumentExceptionWhiteSpace()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("   ", 5, 10));
        }
        
        [Test]
        public void Ctor_DamageThrowArgumentExceptionIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("azo", 0, 10));
        }
        
        [Test]
        public void Ctor_DamageThrowArgumentExceptionIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("azo", -20, 10));
        }

        [Test]
        public void Ctor_HPIsValidForZero()
        {

            Warrior warrior = new Warrior("Pesho", 10, 0);
            Assert.That(warrior.HP == 0);
        }

        [Test]
        public void Ctor_HPThrowArgumentExceptionIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("azo", 5, -20));
        }
        
        [Test]
        public void Attack_Successful()
        {
            Warrior attacker = new Warrior("Gosho", 40, 200);
            Warrior defendant = new Warrior("Pesho", 40, 200);

            int hpAttack = attacker.HP;
            int hpDef = defendant.HP;

            attacker.Attack(defendant);

            Assert.That(attacker.HP == hpAttack - defendant.Damage && defendant.HP == hpDef - attacker.Damage);
        }
        
        [Test]
        public void Attack_SuccessfulAlt()
        {
            Warrior attacker = new Warrior("Gosho", 201, 200);
            Warrior defendant = new Warrior("Pesho", 40, 200);

            int hpAttack = attacker.HP;
            int hpDef = defendant.HP;

            attacker.Attack(defendant);

            Assert.That(attacker.HP == hpAttack - defendant.Damage && defendant.HP == 0);
        }

        [Test]
        public void Attack_ThrowInvalidOperationExceptionAttackHPLessthan30()
        {
            Warrior attacker = new Warrior("Gosho", 40, 29);
            Warrior defendant = new Warrior("Pesho", 5, 200);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defendant));
        }
        
        [Test]
        public void Attack_ThrowInvalidOperationExceptionDeffencekHPLessthan30()
        {
            Warrior attacker = new Warrior("Gosho", 40, 200);
            Warrior defendant = new Warrior("Pesho", 5, 29);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defendant));
        }
        
        [Test]
        public void Attack_ThrowInvalidOperationExceptionAttackHPLessThanEnmeyDMG()
        {
            Warrior attacker = new Warrior("Gosho", 40, 40);
            Warrior defendant = new Warrior("Pesho", 50, 50);

            Assert.Throws<InvalidOperationException>(() => attacker.Attack(defendant));
        }

    }
}