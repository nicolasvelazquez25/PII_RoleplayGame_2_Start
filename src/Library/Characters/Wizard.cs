namespace RoleplayGame
{
    public class Wizard : Character
    {
        /*
        Esta clase hereda de la clase padre Character (buscar su comentario para ver lo heredado), lo que incluye los métodos
         AttackValue y DefenseValue, en el primero se utiliza  el ataque del Spellbook y la Staff, en caso de que el personaje posea alguna,
         al igual que en el caso de DefenseValue se usa la defensa de los mismos.(En ambos casos se suman los ataques y 
         defensas)
        */
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