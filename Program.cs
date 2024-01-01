// See https://aka.ms/new-console-template for more information
using hp_system;

Console.WriteLine("Hello, World!");

Health ash = new Health(50);

Console.WriteLine(ash);

ash.AddHP(-10);
Console.WriteLine(ash);
Condition basicAttack = new Condition(30);
Console.WriteLine(basicAttack);
ash.AddCondition(basicAttack);

Console.WriteLine("Before and after attack");
Console.WriteLine(ash);
ash.NextTurn();
Console.WriteLine(ash);
