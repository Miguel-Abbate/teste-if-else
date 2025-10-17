Console.Clear(); 
Console.Write("Nota da P1: ");
string um = Console.ReadLine()!;
double p1 = Convert.ToDouble(um);
Console.Write("Nota da P2: ");
string dois = Console.ReadLine()!;
double p2 = Convert.ToDouble(dois);
double media = (p1 + p2) / 2;


if (media >= 5)
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Média: [{media}]");
Console.WriteLine("Aprovado  ;)");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Média: [{media}]");
Console.WriteLine("Reprovado  */*");
}
Console.ResetColor();