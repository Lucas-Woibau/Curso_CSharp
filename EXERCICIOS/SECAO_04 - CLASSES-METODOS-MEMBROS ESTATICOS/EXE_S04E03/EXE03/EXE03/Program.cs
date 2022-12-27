using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

namespace EXE03
{
    /*Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida,
    mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classecomo mostrado no projeto ao lado.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Digite a largura e altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area: {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}