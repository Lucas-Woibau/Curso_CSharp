using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_LOGICO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            int N;
            int dentro = 0, fora = 0;

            Console.WriteLine("Digite o valor total de números: ");
            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um número: ");
                X = int.Parse(Console.ReadLine());
                if(X <= 20 && X >= 10)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"In: {dentro}\nOut: {fora}");
            Console.ReadKey();
        }
    }
}
