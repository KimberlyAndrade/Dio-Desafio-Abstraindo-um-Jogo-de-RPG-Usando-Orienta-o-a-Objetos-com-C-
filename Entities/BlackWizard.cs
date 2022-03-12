namespace Abstraindo_um_jogo_de_RPG.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard (string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Lançou uma magia negra!";
        }

        public string Attack(int bonus)
        {
            if(bonus>6) 
            {
                return this.name + " Lançou magia negra destrutiva com bonus de " + bonus;
            } else {
                return this.name + " Lançou magia negra fraca com bonus de " + bonus;
            }
        }
    }
}