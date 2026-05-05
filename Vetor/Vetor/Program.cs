using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i ++)
            {
                soma += vetor[i];
            }

            double resultado = soma / n;

            Console.WriteLine($"AVERAGE HEIGHT = {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}