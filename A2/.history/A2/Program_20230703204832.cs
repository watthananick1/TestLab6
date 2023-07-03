using System;

namespace A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfLine;
            Console.Write("How many numbers :> ");
            int.TryParse(Console.ReadLine(), out lengthOfLine);

            float[] lists = new float[lengthOfLine];

            for (int i = 0; i < lengthOfLine; i++)
            {
                Console.Write("Input data[{0}] :> ", i + 1);
                float.TryParse(Console.ReadLine(), out float numOfLine);
                lists[i] = numOfLine;
            }

            float search, sumOfsearch = 0;
            Console.Write("input data search :> ");
            float.TryParse(Console.ReadLine(), out search);

            Console.WriteLine();

            Console.WriteLine("index");
            for (int i = 0; i < lists.Length; i++)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            for (int j =  0; j < lists.Length; j++) 
            {
                if (lists[j] == search)
                {
                    sumOfsearch += lists[j];
                }
                else { }
                Console.Write(lists[j] + "\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("data\tsum");
            Console.WriteLine(search + "\t" + sumOfsearch);
        }
    }
}
