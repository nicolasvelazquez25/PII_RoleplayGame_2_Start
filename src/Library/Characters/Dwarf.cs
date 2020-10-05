namespace RoleplayGame
{
    public class Dwarf : Character
    {
        /*
        Esta clase hereda de la clase padre Character (buscar su comentario para ver lo heredado), lo que incluye los métodos abstractos
         AttackValue y DefenseValue, en el primero se utiliza unicamente el ataque del Axe, en caso de que el personaje posea uno,
         en cambio, en el caso de DefenseValue se usa la defensa del Helmet y del Shield, en caso de que el personaje las posea.
         (En ambos casos se suman los ataques y defensas, siendo la defensa del Axe cero, al igual que el ataque tanto de Helmet, como de Shield)
        */
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