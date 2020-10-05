using NUnit.Framework;
using RoleplayGame;
using Test.Library;
namespace Test.Library
{
    public class KnightTest
    {
        private Knight dummy;
        private Sword sword;
        private Shield shield;
        private Armor armor;

        [SetUp]
        public void SetUp()
        {
            sword = new Sword();
            shield = new Shield();
            armor = new Armor();
            
            dummy = new Knight("Dummy");
            dummy.Sword = sword;
            dummy.Shield = shield;
            dummy.Armor = armor;
        }

        [Test]
        public void CorrectHealthRestore()
        {
            int dummy1InitialHealth = this.dummy.Health;
            int damage = 50;
            dummy.ReceiveAttack(damage);
            dummy.Cure();
            Assert.AreEqual(dummy1InitialHealth, dummy.Health);
        }

        [Test]
        public void CorrectDamageTaken()
        {
            int dummy1InitialHealth = this.dummy.Health;
            int damage = 50;
            dummy.ReceiveAttack(damage);
            Assert.AreEqual(dummy1InitialHealth - (damage - (this.shield.DefenseValue + this.armor.DefenseValue)), dummy.Health);
        }

        [Test]
        public void CorrectTotalDamage()
        {
            Assert.AreEqual(dummy.AttackValue, sword.AttackValue);
        }

        [Test]
        public void CorrectTotalArmor()
        {
            Assert.AreEqual(dummy.DefenseValue, (shield.DefenseValue + armor.DefenseValue));
        }
    }
}