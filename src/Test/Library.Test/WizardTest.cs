using NUnit.Framework;
using RoleplayGame;
using Test.Library;
namespace Test.Library 
{
    public class WizardTest
    {
        private Wizard dummy;
        private SpellsBook spellsBook;
        private Staff staff;
        private Spell spell;

        [SetUp]
        public void SetUp()
        {
            spellsBook = new SpellsBook();
            staff = new Staff();
            spell = new Spell(); 

            dummy = new Wizard("Dummy");
            dummy.SpellsBook = spellsBook;
            dummy.Staff = staff;
            spellsBook.Spells = new Spell[]{spell};
        }

        [Test]
        public void CorrectHealthRestore()
        {
            int dummy1InitialHealth = this.dummy.Health;
            int damage = this.staff.AttackValue;
            dummy.ReceiveAttack(damage);
            dummy.Cure();
            Assert.AreEqual(dummy1InitialHealth, dummy.Health);
        }

        [Test]
        public void CorrectDamageTaken()
        {
            int dummy1InitialHealth = this.dummy.Health;
            int damage = 200;
            dummy.ReceiveAttack(damage);
            Assert.AreEqual(dummy1InitialHealth - (damage - this.dummy.DefenseValue), dummy.Health);
        }

        [Test]
        public void CorrectTotalDamage()
        {
            Assert.AreEqual(dummy.AttackValue, spellsBook.AttackValue + staff.AttackValue);
        }

        [Test]
        public void CorrectTotalArmor()
        {
            Assert.AreEqual(dummy.DefenseValue, spellsBook.DefenseValue + staff.DefenseValue);
        }
    }
}