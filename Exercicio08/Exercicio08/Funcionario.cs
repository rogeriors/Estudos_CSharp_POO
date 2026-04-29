using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio08
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double liquido = SalarioBruto - Imposto;
            return liquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100;
        }

        override public string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
