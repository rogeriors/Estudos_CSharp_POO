using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio09
{
    internal class NotaAluno
    {
        public string Nome;
        public double Nota01;
        public double Nota02;
        public double Nota03;

        public double NotaFinal ()
        {
            return Nota01 + Nota02 + Nota03;
        }

        public string Aprovacao()
        {
            if (NotaFinal() > 60)
            {
                return "APROVADO";
            }
            else
            {
                double faltam = 60 - NotaFinal();
                return $"REPROVADO\nFALTAM {faltam.ToString("F2",CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
