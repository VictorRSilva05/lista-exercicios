namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o salário do vendedor: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.Write("Insira o valor total das vendas realizadas pelo vendedor: ");
            decimal valorTotalVendas = decimal.Parse(Console.ReadLine());

            Console.Write("Insira a porcentagem de comissão do vendedor: ");
            decimal porcentagemComissao = decimal.Parse(Console.ReadLine());

            decimal comissao = valorTotalVendas * (porcentagemComissao / 100);
            decimal salarioFinal = salario + comissao;

            Console.WriteLine($"\nO salário final do vendedor é R${salarioFinal.ToString("F2"}");

        }
    }
}
