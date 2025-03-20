namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quilometragem inicial: ");
            double quilometragemInicial = double.Parse(Console.ReadLine());

            Console.Write("Insira a quilometragem final: ");
            double quilometragemFinal = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de combustível gasta em litros: ");
            double combustivelGasto = double.Parse(Console.ReadLine());

            double KmPorLitro = (quilometragemFinal - quilometragemInicial) / combustivelGasto;

            Console.WriteLine($"\nO carro fez {KmPorLitro.ToString("F2")}km/l");
        }
    }
}
