namespace Abstraindo_um_jogo_de_RPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Lançou uma magia!";
        }

        public string Attack(int bonus)
        {
            if(bonus>6) 
            {
                return this.name + " Lançou magia super efetiva com bonus de " + bonus;
            } else {
                return this.name + " Lançou magia fraca com bonus de " + bonus;
            }
        }
    }
}