using System;
using System.Collections.Generic;
using SQL_AlgebraRelacional.Entities2;
using System.IO;
using System.Globalization;
using System.Linq;

namespace SQL_AlgebraRelacional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    string email = fields[1];
                    list.Add(new Employee(name, salary, email));
                }
            }
            var emailOA = list.Where(e => e.Salary > limit).OrderBy(e => e.Name).Select(e => e.Email);
            Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emailOA)
            {
                Console.WriteLine(email);
            }

            var soma = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M':" + soma.ToString("F2", CultureInfo.InvariantCulture));
     
        }
    }
}
