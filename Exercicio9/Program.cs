namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o comprimento do terreno: ");
            float comprimento = float.Parse(Console.ReadLine());

            Console.Write("Insira a largura do terreno: ");
            float largura = float.Parse(Console.ReadLine());

            float area = comprimento * largura;

            Console.WriteLine($"\nA área do terreno é {area}m²");
        }
    }
}
