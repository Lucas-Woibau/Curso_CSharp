using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_LOGICO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Digite os coeficientes dos valores (a, b, c): ");
            a = float.Parse(Console.ReadLine()); b = float.Parse(Console.ReadLine()); c = float.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(b)) + raiz) / (2 * a);
            var x2 = ((-(b)) - raiz) / (2 * a);

            Console.WriteLine($"X1: {x1}\nX2: {x2}");
            Console.ReadKey();
        }
    }
}
