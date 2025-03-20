namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu peso em Kg: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Insira sua altura em metros: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if(imc > 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc >= 18.5 && imc < 25)
                Console.WriteLine("Peso normal");
            else if (imc >= 25 && imc < 30)
                Console.WriteLine("Sobrepeso");    
        }
    }
}
