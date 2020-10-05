namespace RoleplayGame
{
public class Knight : Character
    {
        /*
        Esta clase hereda de la clase padre Character (buscar su comentario para ver lo heredado), lo que incluye los métodos
         AttackValue y DefenseValue, en el primero se utiliza unicamente el ataque del Sword, en caso de que el personaje posea uno,
         al igual que en el caso de DefenseValue se usa unicamente la defensa del Armor.(En ambos casos se suman los ataques y 
         defensas, siendo la defensa del Sword cero, al igual que el ataque del Armor)
        */
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