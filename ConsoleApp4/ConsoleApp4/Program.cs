using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de linhas para a matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de colunas para a matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Informe o conteúdo da " + (i + 1) + "ª linha");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Informe um número que pertença à matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == mat[i,j])
                    {
                        Console.WriteLine("Position: " + i + ", " + j + ":");

                        if (i > 0)
                        Console.WriteLine("Up: " + mat [i - 1, j]);
                        if (i < m - 1)
                        Console.WriteLine("Down: " + mat[i + 1, j] );
                        if (j < n - 1)
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (j > 0)
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                }
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
}