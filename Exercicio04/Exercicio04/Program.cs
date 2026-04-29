using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Xml;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login: Admin");
            Console.Write("Password: ");
            int pass = int.Parse(Console.ReadLine());
            int block = 1;


            while (pass != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Login: Admin");
                Console.Write("Password: ");
                pass = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");


            /* Console.WriteLine("---------------------------------------");
            Console.WriteLine("Digite dois numeros para o quadrante cartesiano X e Y:");
            string[] num = Console.ReadLine().Split(' ');
            double x = double.Parse(num[0]);
            double y = double.Parse(num[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0) Console.WriteLine("primeiro");
                else if (x < 0 && y > 0) Console.WriteLine("segundo");
                else if (x < 0 && y < 0) Console.WriteLine("terceiro");
                else Console.WriteLine("quarto");
                return;
            } */

            Console.WriteLine("---------------------------------------");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Qual sua preferencia de combustivel?");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Sair");
            int resp = int.Parse(Console.ReadLine());

            while (resp < 1 || resp > 4)
            {
                Console.Clear();
                Console.WriteLine("Digite um valor valido");
                Console.WriteLine("Digite novamente:");
                resp = int.Parse(Console.ReadLine());
                Console.Clear();
            }


            while (resp != 4)
            {
                if (resp == 1)
                {
                    alcool++;
                }
                else if (resp == 2)
                {
                    gasolina++;
                }
                else
                {
                    diesel++;
                }
                Console.Clear();
                Console.WriteLine("Qual sua preferencia de combustivel?");
                Console.WriteLine("1. Álcool");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Sair");
                resp = int.Parse(Console.ReadLine());
                Console.Clear();
            }


            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}