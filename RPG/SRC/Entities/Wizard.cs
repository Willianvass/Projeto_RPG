namespace RPG.SRC.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia!";
        } 

        public string Attack(int Bonus)
        {

            if(Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de" + Bonus; 
            }
            else
            {
                return this.Name + " Lançou uma magia fraca com bonus de" + Bonus;
            }
       }   
    }
}