namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o salário do funcionário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal novoSalario = salario + (salario * 0.15m);

            decimal salarioLiquido = novoSalario - (novoSalario * 0.08m);

            Console.WriteLine($"Salário bruto: R${novoSalario.ToString("F2")}, salário líquido: R${salarioLiquido.ToString("F2")}");
        }
    }
}
