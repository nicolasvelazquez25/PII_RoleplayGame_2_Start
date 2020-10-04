namespace RoleplayGame
{
    public abstract class Character
    {
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