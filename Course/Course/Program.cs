using System;
using System.Numerics;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char genero = 'M';
            bool completo = false;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria";
            int idade = 31;
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;
            double saldo = 10.35784;





            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome,idade,saldo); // Placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("f2", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem aldo igual a " + saldo.ToString("f2") + " reais");

            Console.WriteLine(saldo.ToString("f2"));
            Console.WriteLine(saldo.ToString("f4"),CultureInfo.InvariantCulture);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
        }
    }
}