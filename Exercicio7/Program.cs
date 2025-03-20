namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a nota da primeira prova: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.Write("Insira o peso da primeira prova: ");
            decimal peso1 = decimal.Parse(Console.ReadLine());

            Console.Write("Insira a nota da segunda prova: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            Console.Write("Insira o peso da segunda prova: ");
            decimal peso2 = decimal.Parse(Console.ReadLine());

            decimal mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine($"A media ponderada é de: {mediaPonderada.ToString("F1")}");
        }
    }
}
