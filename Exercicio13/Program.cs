namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor A: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor B: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor C: ");
            float c = float.Parse(Console.ReadLine());

            bool equacaoValida = (a + b) < c ? false : true;

            if(equacaoValida)
                Console.WriteLine("C é menor que a soma de A e B");
            else
                Console.WriteLine("C é maior que a soma de A e B");
        }
    }
}
