namespace RoleplayGame
{
    public class Wizard : Character
    {
        private int health = 100;
        public Wizard(string name)    
                :base(name)
        {
        }
        private string name;
        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public override int AttackValue
        {
            get
            {
                if (SpellsBook == null & Staff != null)
                {
                    return SpellsBook.AttackValue;
                }
                if (SpellsBook == null & Staff != null)
                {
                    return Staff.AttackValue;
                }
                if (SpellsBook != null & Staff != null)
                {
                    return Staff.AttackValue + SpellsBook.AttackValue;;
                }
                else
                {
                    return 0;
                }
            }
        }

        public override int DefenseValue
        {
            get
            {
                if (SpellsBook == null & Staff != null)
                {
                    return SpellsBook.DefenseValue;
                }
                if (SpellsBook == null & Staff != null)
                {
                    return Staff.DefenseValue;
                }
                if (SpellsBook != null & Staff != null)
                {
                    return Staff.DefenseValue + SpellsBook.DefenseValue;;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}