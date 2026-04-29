using System;
using System.Globalization;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares vocÊ vai comprar? ");
            double quantiaDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversorDeMoeda.CotacaoDolar(cotacaoDolar, quantiaDolar);

            Console.WriteLine($"Valor a ser pago em reais = {valorEmReais.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}