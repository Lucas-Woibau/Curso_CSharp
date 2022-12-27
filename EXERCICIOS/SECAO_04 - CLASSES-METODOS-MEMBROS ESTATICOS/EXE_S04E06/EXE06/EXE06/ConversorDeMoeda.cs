using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE06
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
