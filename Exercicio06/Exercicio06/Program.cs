using System;
using System.Globalization;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario01, funcionario02;
            funcionario01 = new Funcionarios();
            funcionario02 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario01.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario01.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario02.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario02.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario01.Salario + funcionario02.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}