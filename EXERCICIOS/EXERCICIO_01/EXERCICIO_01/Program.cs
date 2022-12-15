using System.Globalization;

namespace EXERCICIO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto01 = "Computador";
            string produto02 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto01}, cujo o preço é R${preco1}");
            Console.WriteLine($"{produto02},cujo o preço é R${preco2}");
            Console.WriteLine("Registro: ");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}