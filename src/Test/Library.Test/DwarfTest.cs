using NUnit.Framework;
using RoleplayGame;
using Test.Library;
namespace Test.Library 
{
    public class DwarfTest
    {
        private Dwarf dummy;
        private Axe axe;
        private Shield shield;
        private Helmet helmet;

        [SetUp]
        public void SetUp()
        {
            axe = new Axe();
            shield = new Shield();
            helmet = new Helmet();
            
            dummy = new Dwarf("Dummy");
            dummy.Axe = axe;
            dummy.Shield = shield;
            dummy.Helmet = helmet;
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
            Assert.AreEqual(dummy1InitialHealth - (damage - this.helmet.DefenseValue - this.shield.DefenseValue), dummy.Health);
        }

        [Test]
        public void CorrectTotalDamage()
        {
            Assert.AreEqual(dummy.AttackValue, axe.AttackValue);
        }

        [Test]
        public void CorrectTotalArmor()
        {
            Assert.AreEqual(dummy.DefenseValue, helmet.DefenseValue + shield.DefenseValue);
        }
    }
}