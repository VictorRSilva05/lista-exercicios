namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            float numero = float.Parse(Console.ReadLine());

            if (numero % 1 == 0 && numero % numero == 0)
                Console.WriteLine("O número é primo");
            else
                Console.WriteLine("O número não é primo");
        }
    }
}
