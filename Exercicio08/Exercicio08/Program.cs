using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Exercicio08
{
    class Program
    {
        public static void Main(string[] args)
        {
            Funcionario nome;
            nome = new Funcionario();

            Console.Write("Nome: ");
            nome.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            nome.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            nome.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine($"Funcionário: {nome.Nome}, $ {nome.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nome.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {nome}");
        }
    }
}