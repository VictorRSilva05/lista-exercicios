namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somaImpares = default;

            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    somaImpares += 1;
                }
            }

            Console.WriteLine(somaImpares);
        }
    }
}
