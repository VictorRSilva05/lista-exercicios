namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor A: ");
            int valor = int.Parse(Console.ReadLine());

            int valorTotal = valor;

            Console.Write($"{valor}! = {valor}");
            for (int i = valor - 1; i > 0; i--)
            {
                valorTotal *= i;
                Console.Write($" X {i} ");
            }

            Console.Write($"= {valorTotal}");
        }
    }
}
