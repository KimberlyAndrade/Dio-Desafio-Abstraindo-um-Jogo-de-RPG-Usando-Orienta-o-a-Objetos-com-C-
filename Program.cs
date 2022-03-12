using Abstraindo_um_jogo_de_RPG.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard jennica = new Wizard("Jennica", 23, "Wizard");
Ninja wedge = new Ninja("Wedge", 23, "Ninja");
BlackWizard topapa = new BlackWizard("Topapa", 23, "Black Wizard");

Console.WriteLine($@"
Lista de Personagens:
{arus}
{jennica}
{wedge}
{topapa}
");

Console.WriteLine($@"Ações do RPG:
");
Console.WriteLine(arus.Attack());
Console.WriteLine(jennica.Attack(8));
Console.WriteLine(wedge.Attack(3));
Console.WriteLine(topapa.Attack(5));