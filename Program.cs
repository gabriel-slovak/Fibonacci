using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, valor1 = 1, valor2 = 0, valor3 = 1;
            bool result;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n-- Fibonacci --\n");  
            Console.ResetColor();

            Console.Write("Insira a quantidade de termos...: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            result = Int32.TryParse(Console.ReadLine(), out valor);
            Console.ResetColor();

            for (int finish = 0; finish < valor; finish++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(valor2);
                valor3 = valor2;
                valor2 = valor1;
                valor1 = valor2 + valor3;
                Console.ResetColor();
            }
            if (valor < 2 || !result)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNumero inválido, tente um numero válido.\n");
                Environment.Exit(-1);
                Console.ResetColor();
                Console.WriteLine();
            }
           
        }
    }
}
