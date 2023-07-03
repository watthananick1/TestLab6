using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest
{
    internal class Program
    {
        static void Triangle()
        {
            int widthOfLine;
            Console.Write("input width of line :> ");
            int.TryParse(Console.ReadLine(), out widthOfLine);

            for (int i = widthOfLine; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(i + "\n");
            }

        }
        static void Rectangle()
        {
            int lengthOfLine, numOfLine;
            Console.Write("input length of line :> ");
            int.TryParse(Console.ReadLine(), out lengthOfLine);
            Console.Write("input number of lines :> ");
            int.TryParse(Console.ReadLine(), out numOfLine);

            for (int i = 0; i < numOfLine; i++)
            {
                for (int j = 1; j <= lengthOfLine; j++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }
        }
        static void Line()
        {
            int numOfLine;
            Console.Write("input length of line :> ");
            int.TryParse(Console.ReadLine(), out numOfLine);

            numOfLine--;

            while (numOfLine >= 0) 
            {
                Console.Write(numOfLine --);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("    Menu     ");
            Console.WriteLine("1 - Line");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Triangle");
            Console.WriteLine("4 - Exit PRG\n");

            while (true) 
            {
                int num;
                Console.Write("menu :> ");
                int.TryParse(Console.ReadLine(), out num);
                switch (num) 
                {
                    case 1:
                        Console.WriteLine();
                        Line();
                        continue;
                    case 2:
                        Console.WriteLine();
                        Rectangle();
                        continue;
                    case 3:
                        Console.WriteLine();
                        Triangle();
                        continue;
                    case 4:
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("Exit program....\n");
                break;
               
            }
            

        }
    }
}
