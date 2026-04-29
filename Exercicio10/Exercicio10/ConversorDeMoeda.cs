using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double CotacaoDolar(double cotacao, double dolar)
        {
            double valorSemIOF = dolar * cotacao;
            return valorSemIOF + (valorSemIOF * IOF / 100);
        }

    }
}
