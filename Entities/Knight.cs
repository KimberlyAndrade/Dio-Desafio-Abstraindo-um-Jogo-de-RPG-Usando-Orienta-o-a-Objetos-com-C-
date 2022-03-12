namespace Abstraindo_um_jogo_de_RPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
    }
}