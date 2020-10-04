namespace RoleplayGame
{
    public class Dwarf : Character
    {
        private int health = 100;
        public Dwarf(string name)    
                :base(name)
        {
        }

        private string name;
        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public override int AttackValue
        {
            get
            {
                if (Axe != null)
                {
                    return Axe.AttackValue;
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
                if (Shield == null & Helmet != null)
                {
                    return Helmet.DefenseValue;
                }
                if (Helmet == null & Shield != null)
                {
                    return Shield.DefenseValue;
                }
                if (Helmet != null & Shield != null)
                {
                    return Shield.DefenseValue + Helmet.DefenseValue;;
                }
                else
                {
                    return 0;
                }
            }
        }
    } 
}