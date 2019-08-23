using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            list.Add("Bibi");
            list.Add("Niko");
            list.Insert(1, "<3");
            list.Add("Narizinho");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count:" + list.Count);

            string s1 = list.Find(x => x[0] == 'N');
            Console.WriteLine("First 'N': " + s1);

            string s2 = list.FindLast(x => x[0] == 'N');
            Console.WriteLine("Last 'N': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'N');
            Console.WriteLine("First position 'N': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'N');
            Console.WriteLine("First position 'N': " + pos2);


            List<string> list2 = list.FindAll(x => x.Length == 4);
            Console.WriteLine("-----------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");

            list.Remove("Narizinho");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] != 'N');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //A lista tem tamanho variável, você pode inserir novos dados depois que já instanciou o vetor

            //Acesso sequencial de elementos: mais lento que o acesso direto ao vetor que você deseja


        }




    }

}
