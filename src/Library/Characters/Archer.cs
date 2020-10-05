namespace RoleplayGame
{
    public class Archer : Character
    {
        /*
        Esta clase hereda de la clase padre Character (buscar su comentario para ver lo heredado), lo que incluye los métodos
         AttackValue y DefenseValue, en el primero se utiliza unicamente el ataque del Bow, en caso de que el personaje posea uno,
         al igual que en el caso de DefenseValue se usa unicamente la defensa del Helmet.(En ambos casos se suman los ataques y 
         defensas, siendo la defensa del Bow cero, al igual que el ataque del Helmet)
        */
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