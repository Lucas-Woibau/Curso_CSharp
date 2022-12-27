using System.Globalization;

namespace EXE06
{

    /* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprador por uma pessoa em reais.
       Informar quantos reais a pessoa vai pagar em dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre 
       o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cotação do dólar:");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dólar a ser comprado: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais: {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}