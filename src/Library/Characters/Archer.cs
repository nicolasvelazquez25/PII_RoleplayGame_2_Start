namespace RoleplayGame
{
    public class Archer : Character
    {
        private int health = 100;
        public Archer(string name)    
                :base(name)
        {
        }

        private string name;
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public override int AttackValue
        {
            get
            {
                if (Bow != null)
                {
                return Bow.AttackValue;
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
                if (Helmet != null)
                {
                    return Helmet.DefenseValue;
                }
                else
                {
                    return 0;
                }
            }
        }     
    }
}