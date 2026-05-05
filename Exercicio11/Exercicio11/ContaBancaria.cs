using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio11
{
    internal class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; private set; }

       
        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(int conta, string nome, double depositoInicial) : this(conta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }


        override public string ToString()
        {
            return $"Dados da conta atualizados: \nConta {Conta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";

        }
    }
}