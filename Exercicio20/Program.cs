namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor de 1 a 10: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 1 || valor > 10)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{valor} x {i} = {valor * i}");
                }
            }
        }
    }
}
