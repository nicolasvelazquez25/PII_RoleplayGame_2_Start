using NUnit.Framework;
using RoleplayGame;
using Test.Library;
namespace Test.Library
{
    public class ArcherTest
    {
        private Archer dummy;
        private Bow bow;
        private Helmet helmet;

        [SetUp]
        public void SetUp()
        {
            bow = new Bow();
            helmet = new Helmet();
            
            dummy = new Archer("Dummy");
            dummy.Bow = bow;
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
            Assert.AreEqual(dummy1InitialHealth - (damage - this.helmet.DefenseValue), dummy.Health);
        }

        [Test]
        public void CorrectTotalDamage()
        {
            Assert.AreEqual(dummy.AttackValue, bow.AttackValue);
        }

        [Test]
        public void CorrectTotalArmor()
        {
            Assert.AreEqual(dummy.DefenseValue, helmet.DefenseValue);
        }
    }
}