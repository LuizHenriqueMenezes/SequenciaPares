using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" \n----- SEQUÊNCIA PARES ----- \n");
            Console.ResetColor();

            Console.Write("Insira um número inteiro: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i <= x)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nObrigado por usar nosso programa. Pressione qualquer tecla para finalizar. ");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
