using System;
using System.IO;
using System.Globalization;

namespace Files_Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFoderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFoderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFoderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurrend");
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
