namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            for(int i = 0; i < 3; i++)
            {
                Console.Write($"Insira o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            numeros.OrderDescending();

            Console.WriteLine($"\n{numeros[2]}, {numeros[1]}, {numeros[0]}");
        }
    }
}
