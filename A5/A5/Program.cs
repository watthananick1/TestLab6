using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many number :> ");
            int N = int.Parse(Console.ReadLine());

            int[] array1 = new int[N];
            int[] array2 = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"input data1[{i + 1}] :> ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n----------------------");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"input data2[{i + 1}] :> ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            int sumOfDifferencesSquared = 0;
            for (int i = 0; i < N; i++)
            {
                int difference = array1[i] - array2[i];
                int differenceSquared = difference * difference;
                Console.WriteLine($"data1[{array1[i]}] - data2[{array2[i]}] = {differenceSquared}");
                sumOfDifferencesSquared += differenceSquared;
            }

            Console.WriteLine("------------------------------------\n");
            Console.WriteLine($"sum of Diff-Square is {sumOfDifferencesSquared}");
        }
    }
}
