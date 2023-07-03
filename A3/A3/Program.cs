using System;
using System.Linq;

namespace A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfLine;
            Console.Write("How many number :> ");
            int.TryParse(Console.ReadLine(), out lengthOfLine);

            float[] lists = new float[lengthOfLine];

            for (int i = 0; i < lengthOfLine; i++)
            {
                Console.Write("Input data[{0}] :> ", i + 1);
                float.TryParse(Console.ReadLine(), out float numOfLine);
                lists[i] = numOfLine;
            }

            float max = lists.Max();
            float min = lists.Min();
            float diff = max - min;

            Console.WriteLine();
            Console.WriteLine("Max is " + max);
            Console.WriteLine("Min is " + min);
            Console.WriteLine("Diff is " +  diff);
        }
    }
}
