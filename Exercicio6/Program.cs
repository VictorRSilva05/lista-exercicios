namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> notas = new List<decimal>();
            List<decimal> inversos = new List<decimal>();

            while (true)
            {
                Console.Write("Insira a nota do aluno (ou digite 'sair' para sair): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "sair")
                {
                    break;
                }
                decimal nota = decimal.Parse(input);
                notas.Add(nota);
            }

            foreach (decimal nota in notas)
            {
                inversos.Add(1 / nota);
            }

            decimal mediaHarmonica = notas.Count / inversos.Sum();

            Console.WriteLine($"A média harmônica das notas é de: {mediaHarmonica.ToString("F1")}");

        }
    }
}
