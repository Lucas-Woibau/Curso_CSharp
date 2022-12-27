using System.Globalization;

namespace EXE04
{
    /* Fazer um programa para ler os dados de um funcionário (nome, 
    salário bruto e imposto). Em seguida, mostrar os dados do 
    funcionário (nome e salário líquido). Em seguida, aumentar o salário 
    do funcionário com base em uma porcentagem dada (somente o 
    salário bruto é afetado pela porcentagem) e mostrar novamente os 
    dados do funcionário. Use a classe projetada abaixo. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionario: {func.Nome}");

            Console.WriteLine("Deseja aumentar o salário em quantos por cento? ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine($"Dados do funcionario: {func} ");
        }
    }
}