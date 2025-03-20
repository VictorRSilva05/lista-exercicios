namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a altura da caixa: ");
            float altura = float.Parse(Console.ReadLine());

            Console.Write("Insira a largura da caixa: ");
            float largura = float.Parse(Console.ReadLine());

            Console.Write("Insira o comprimento da caixa: ");
            float comprimento = float.Parse(Console.ReadLine());

            float volume = altura * largura * comprimento;

            Console.WriteLine($"\nO volume da caixa é {volume}cm²");
        }
    }
}
