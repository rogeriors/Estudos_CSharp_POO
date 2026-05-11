using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantia de valores: ");
            int quantia = int.Parse(Console.ReadLine());

            int[] valores = new int[quantia];

            
            for (int i = 0; i < quantia; i++)
            {
                Console.Write("Digite o valor #" + (i + 1) + ": ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            int result = Calculator.Sum(valores);
            Console.WriteLine("Resultado: " + result);
        }
    }
}