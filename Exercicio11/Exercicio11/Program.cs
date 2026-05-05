using System;
using System.Globalization;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine().ToLower());

            ContaBancaria conta = new ContaBancaria(numeroConta, titular);

            if (depositoInicial == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valorDeposito);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {conta.Conta}, Titular: {conta.Nome}, Saldo: $ {conta.Saldo.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine(conta);
        }
    }
}