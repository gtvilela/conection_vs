using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Entities;
using System.Globalization;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string p = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (p == "c")
                {
                    list.Add(new Product(name, price));

                }
                else if (p == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(customs, name, price));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
