using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {


            // ------------------------------------------------------
            Console.WriteLine("Digite o código e a quantidade:");
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);
            double preco = 0.0;
            
            if (cod <= 0 || cod > 5)
            {
                Console.WriteLine("Código inválido.");
                return;
            }
            else if (cod == 1) preco = 4.00;
            else if (cod == 2) preco = 4.50;
            else if (cod == 3) preco = 5.00;
            else if (cod == 4) preco = 2.00;
            else if (cod == 5) preco = 1.50;
            double total = preco * qtd;

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------------




        }
    }
}