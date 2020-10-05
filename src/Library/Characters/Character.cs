namespace RoleplayGame
{
    public abstract class Character
    {
        /*
        Creamos la clase abstracta Character, de la que heredaran todos los personajes del código variables como la vida, que es igual a 100, el nombre que
        se ingresa mediante el constructor, los getter y setter de la vida y el getter del nombre, de igual manera, se hereda el método para recibir un ataque 
        y curarse a su vida inicial. Finalmente existen dos metodos llamadas AttackValue y DefenseValue que dependerá de los items de los 
        personajes en sí. 
        */
        private int health = 100;

        public Character(string name)
        {
            this.name = name;
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }            
        }

        public abstract int AttackValue{get;}

        public abstract int DefenseValue{get;}

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        } 
        public void Cure()
        {
            this.Health = 100;
        }
    }
}