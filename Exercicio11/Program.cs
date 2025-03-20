namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            int dias = idade * 365;

            Console.WriteLine($"\n{nome}, você já viveu {dias} dias");
        }
    }
}
