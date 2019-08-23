using System;
using ConsoleApp6.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da pessoa #{i}:");
                Console.Write("Física ou Jurídica (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String name = Console.ReadLine();
                Console.Write("Renda anual: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Gastos com saúde: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Fisica(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Juridica(name, income, numberOfEmployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Impostos pagos:");
            foreach (Pessoa tp in list)
            {
                double tax = tp.CalculaImposto();
                Console.WriteLine(tp.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("Total de impostos pagos: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    }
}
