using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada:");
            string[] entrada = Console.ReadLine().Split(' ');
            float a = float.Parse(entrada[0], CultureInfo.InvariantCulture);
            float b = float.Parse(entrada[1], CultureInfo.InvariantCulture);
            float c = float.Parse(entrada[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2.0;
            double circulo = Math.PI * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2.0;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("f3", CultureInfo.InvariantCulture)}");


            Console.WriteLine("-------------------------");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = 0.0;
            double vDesconto = 0.0;

            if ( preco > 100.0)
            {
                desconto = preco * 0.1;
                vDesconto = preco - preco * 0.1;
            }
            Console.WriteLine($"Desconto de: R${desconto}");
            Console.WriteLine($"Valor a pagar: R${vDesconto}");
        }
    }
}