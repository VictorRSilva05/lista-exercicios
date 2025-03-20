namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorPao = 0.12m;
            decimal valorBroa = 1.50m;

            Console.Write("Insira a quantidade de pães vendidos: ");
            int quantidadePaes = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de broas vendidas: ");
            int quantidadeBroas = int.Parse(Console.ReadLine());

            decimal totalVendas = (valorPao * quantidadePaes) + (valorBroa * quantidadeBroas);

            decimal poupanca = totalVendas * 0.1m;

            Console.WriteLine($"\nO valor total das vendas foi de R${totalVendas.ToString("F2")}");
            Console.WriteLine($"O valor a ser guardado na poupança é de R${poupanca.ToString("F2")}");
        }
    }
}
