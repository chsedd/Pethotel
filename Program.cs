using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
        Console.WriteLine("+=========================================================+");
        Console.ResetColor();

        Console.Write("Espécie: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string especie = Console.ReadLine().ToUpper();
        Console.ResetColor();

        Console.Write("Raça: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string raca = Console.ReadLine().ToUpper();
        if (string.IsNullOrWhiteSpace(raca)) raca = "INDEFINIDA";
        Console.ResetColor();

        Console.Write("Nome do pet: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string nome = Console.ReadLine().ToUpper();
        Console.ResetColor();

        Console.Write("Idade (anos): ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        int idade = int.Parse(Console.ReadLine());
        Console.ResetColor();

        Console.Write("Pelagem/cor: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string pelagem = Console.ReadLine().ToUpper();
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
        Console.WriteLine("+=========================================================+");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("| Espécie: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(especie);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" | Raça: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(raca);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" |");
        Console.WriteLine("+=========================================================+");
        
        Console.Write("| Atende pela alcunha de: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(nome.PadLeft(30, '.'));
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write("| Idade: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(idade.ToString("D2"));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" ano(s) | Pelagem/cor: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(pelagem.PadLeft(15, '.'));
        Console.ForegroundColor = ConsoleColor.Gray;
        
        Console.WriteLine("+=========================================================+");
        Console.ResetColor();
    }
}