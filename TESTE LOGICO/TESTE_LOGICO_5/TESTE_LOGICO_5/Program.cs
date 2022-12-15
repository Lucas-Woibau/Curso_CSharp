using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_LOGICO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;
            int senha;
            bool acessoPermitido = false;

           

            while(acessoPermitido == false)
            {
                Console.WriteLine("\nDigite a senha: ");
                senha = int.Parse(Console.ReadLine());

                if(senha == senhaCorreta)
                {
                    Console.WriteLine("\nAcesso permitido");
                    acessoPermitido = true;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nAcesso negado");
                }
            }
        }
    }
}
