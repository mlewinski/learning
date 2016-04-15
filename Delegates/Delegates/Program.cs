using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate long Transformer(long x);
    class Program
    {
        static void Main(string[] args)
        {
            Transformers transformers = new Transformers();
            long[,] table = new long[10,10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) table[i,j] = (random.Next()%100);
            PrintTable(table);
            Transformer t = transformers.OddOrEven;
            Transform(table, t);
            PrintTable(table);
            Console.ReadLine();
        }

        static void PrintTable(long[,] table)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) Console.Write(" {0}", table[i, j]);
                Console.WriteLine();
            }
        }
        static void Transform(long[,] table, Transformer Transformer)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    table[i, j] = Transformer(table[i, j]);
        }
    }
}
