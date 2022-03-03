namespace RPG.SRC.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }   
        public override string Attack()
        {
            return this.Name + " Lançou uma Magia Negra!";
        }
    }
}