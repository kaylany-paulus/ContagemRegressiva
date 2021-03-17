using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("CONTAGEM REGRESSIVA");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Preparar... \n");
            Console.ResetColor();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Apontar... \n");
            Console.ResetColor();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("FOGO!");Console.ResetColor();Console.ReadKey();
            Console.Clear();
        }
    }
}
        
    