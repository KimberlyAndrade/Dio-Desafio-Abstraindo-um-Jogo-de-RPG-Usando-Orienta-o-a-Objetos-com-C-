namespace Abstraindo_um_jogo_de_RPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string Attack()
        {
            return this.name + " Atacou com a katana!";
        }

        public string Attack(int bonus)
        {
            if(bonus>6) 
            {
                return this.name + " Usou golpe ultra forte com bonus de " + bonus;
            } else {
                return this.name + " Usou golpe fraco com bonus de " + bonus;
            }
        }
    }
}