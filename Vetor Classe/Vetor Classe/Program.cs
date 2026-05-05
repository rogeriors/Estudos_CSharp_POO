using System;
using System.Globalization;

namespace Vetor_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            Product[] produto = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the name of product #{i + 1}:");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Price: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Product { Produto = nome, Valor = preco };
            }

            double resultado = 0.0;
            for (int i = 0; i < n; i++)
            {
                resultado += produto[i].Valor;
            }

            Console.WriteLine();
            double resultadoFinal = resultado / n;
            Console.WriteLine($"AVERAGE PRICE = {resultadoFinal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}