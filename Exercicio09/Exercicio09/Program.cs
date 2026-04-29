using System;
using System.Globalization;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaAluno aluno;
            aluno = new NotaAluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine(aluno.Aprovacao());
        }
    }
}