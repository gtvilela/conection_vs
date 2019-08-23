using System;

namespace vetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gentileza informar a quantidade de quartos que serão reservados: ");
            int qtd = int.Parse(Console.ReadLine());

            string[] vet = new string[10];
            Estudante e = new Estudante();


            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Informe o nome do " + (i + 1) + "º estudante:");
                e.Nome = Console.ReadLine();

                Console.WriteLine("Informe o e-mail do estudante:");
                e.Email = Console.ReadLine();

                Console.WriteLine("Informe o número do quarto do estudante:");
                e.Numero = int.Parse(Console.ReadLine());

                if (vet[i] != null) { 
                vet[e.Numero] = vet[i];
                }
            }

            for (int i = 0; i < qtd; i++)
            {

            
            Console.WriteLine("Reservas");
                Console.WriteLine("Nome do estudante do quarto " + vet[e.Numero] + " é: " + e.Nome);
                Console.WriteLine("E-mail do estudante do quarto " + vet[e.Numero] + " é: " + e.Email);
                Console.WriteLine();

            }

            Console.ReadKey();

        }
    }
}
