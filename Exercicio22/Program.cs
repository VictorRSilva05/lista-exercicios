namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());
            
            int sequencia = 0;

            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine($"{sequencia += i}"); 
            }
        }
    }
}
