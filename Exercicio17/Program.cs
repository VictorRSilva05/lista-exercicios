namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor B: ");
            int b = int.Parse(Console.ReadLine());

            int c = default;

            if(a == b)
                c = a + b;
            else
                c = a * b;

            Console.WriteLine($"O valor de C é {c}");
        }
    }
}
