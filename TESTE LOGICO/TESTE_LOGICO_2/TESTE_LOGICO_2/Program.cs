using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_LOGICO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            double pi = Math.PI;
            Console.WriteLine("...Calculo de raio...");
            Console.WriteLine("Digite o raio em m²: ");
            raio = float.Parse(Console.ReadLine());

            area = Math.Pow(raio, 2) * 3.14;

            Console.WriteLine($"Area = {area}");
            Console.ReadKey();
        }
    }
}
