using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número de cadastros");
            int numero = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ":");

                Console.WriteLine("Informe o ID do funcionario");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do funcionario");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o salário do funcionario");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Informe o funcionário que gostaria de incrementar o valor no salário:");
            int IdInc = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.Id == IdInc);

            if (func != null)
            {
                Console.WriteLine("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.IncrementarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualização da lista de funcionários: ");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
