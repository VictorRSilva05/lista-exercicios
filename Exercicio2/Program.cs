namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a base do cilindro: ");
            double baseCilindro = double.Parse(Console.ReadLine());

            Console.Write("Insira a altura do cilindro: ");
            double alturaCilindro = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(baseCilindro, 2) * alturaCilindro;

            Console.WriteLine($"\nO volume do cilindro é {volume}cm³");
        }
    }
}
