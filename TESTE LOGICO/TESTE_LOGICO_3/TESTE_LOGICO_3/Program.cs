using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_LOGICO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            float valorTotal;

            Console.WriteLine("------CARDÁPIO------");
            Console.WriteLine("CÓDIGO: 1 | CACHORRO QUENTE | PREÇO: R$4,00");
            Console.WriteLine("CÓDIGO: 2 | X - SALADA | PREÇO: R$4,50");
            Console.WriteLine("CÓDIGO: 3 | X - BACON | PREÇO: R$5,00");
            Console.WriteLine("CÓDIGO: 4 | TORRADA SIMPLES | PREÇO: R$2,00");
            Console.WriteLine("CÓDIGO: 5 | REFRIGERANTE | PREÇO: R$1,50");

            Console.WriteLine("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                valorTotal = quantidade * 4.00f;
                Console.WriteLine($"Valor total a pagar: R${valorTotal}");
                Console.ReadKey();
            }
            if(codigo == 2)
            {
                valorTotal = quantidade * 4.50f;
                Console.WriteLine($"Valor total a pagar: R${valorTotal}");
                Console.ReadKey();
            }
            if(codigo == 3)
            {
                valorTotal = quantidade * 5.00f;
                Console.WriteLine($"Valor total a pagar: R${valorTotal}");
                Console.ReadKey();
            }
            if(codigo == 4)
            {
                valorTotal = quantidade * 2.00f;
                Console.WriteLine($"Valor total a pagar: R${valorTotal}");
                Console.ReadKey();
            }
            if(codigo == 5)
            {
                valorTotal = quantidade * 1.50f;
                Console.WriteLine($"Valor total a pagar: R${valorTotal}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Codigo inválido");
                return;
            }
        }
    }
}
