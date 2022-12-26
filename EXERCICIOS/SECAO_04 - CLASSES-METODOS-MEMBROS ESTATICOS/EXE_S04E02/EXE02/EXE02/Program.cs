using System.Globalization;

namespace EXE02
{
    //Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;

            Funcionario f1 = new Funcionario();
            Funcionario f2= new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionário");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do primeiro funcionario");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o nome do segundo funcionário");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"A média dos salarios dos funcionarios é {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}