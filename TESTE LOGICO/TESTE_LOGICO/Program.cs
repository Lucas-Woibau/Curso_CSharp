using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_LOGICO
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2;
            int num1, num2;
            float valor1, valor2, total1, total2;

            Console.WriteLine("---- Peça01 ----");
            Console.WriteLine("Digite o codigo da peça: ");
            cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a quantidade de peças: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o preço da peça: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("---- Peça02 ----");
            Console.WriteLine("Digite o codigo da peça: ");
            cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a quantidade de peças: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o preço da peça: ");
            valor2 = float.Parse(Console.ReadLine());

            total1 = num1 * valor1;
            total2 = num2 * valor2;

            Console.WriteLine($"Cod Peça: {cod1}\nNumero de Peças: {num1}\nValor total a pagar: R${total1}");
            Console.WriteLine($"Cod Peça: {cod2}\nNumero de Peças: {num2}\nValor total a pagar: R${total2}");
            Console.ReadKey();

        }
    }
}
