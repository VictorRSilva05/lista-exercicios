namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int numeroElementos = int.Parse(Console.ReadLine());

            int elementoAtual = 0;
            int proximoElemento = 1;

            for (int i = 0; i <= numeroElementos; i++)
            {
                int soma = elementoAtual + proximoElemento;
                Console.WriteLine(soma);

                elementoAtual = proximoElemento;
                proximoElemento = soma;
            }
        }
    }
}
