namespace RoleplayGame
{
public class Knight : Character
    {
        private int health = 100;
        public Knight(string name)    
                :base(name)
        {
        }

        private string name;
        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public override int AttackValue
        {
            get
            {
                if (Sword != null)
                {
                    return Sword.AttackValue;
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
                if (Shield == null & Armor != null)
                {
                    return Armor.DefenseValue;
                }
                if (Armor == null & Shield != null)
                {
                    return Shield.DefenseValue;
                }
                if (Armor != null & Shield != null)
                {
                    return Shield.DefenseValue + Armor.DefenseValue;;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}