using System;

namespace Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores: ");
            int a = int.Parse (Console.ReadLine());
            int b = int.Parse (Console.ReadLine());
            int c = int.Parse (Console.ReadLine());
            int d = int.Parse (Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine("Diferenca = " + diferenca);
        }
    }
}
