using System;
using System.Globalization;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um numero para ver seus impares: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("----------------------------------------");

            int posit = 0;
            int negat = 0;

            Console.Write("Digite a quantia de numeros que deseja: ");
            int valor = int.Parse(Console.ReadLine());

            for (int num = 0; num < valor; num++)
            {
                Console.Write("Digite um numero: ");
                int numero2 = int.Parse(Console.ReadLine());

                if ( numero2 >= 10 && numero2 <= 20)
                {
                    posit++;
                } else
                {
                    negat++;
                }
            }
 
            Console.WriteLine($"{posit} in");
            Console.WriteLine($"{negat} out");

            Console.WriteLine("-----------------------------------------");

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++ )
            {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}