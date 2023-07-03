using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many student :> ");
            int totalStudents = int.Parse(Console.ReadLine());

            int pCount = 0; 
            int tCount = 0; 
            int sCount = 0; 
            int aCount = 0; 
            int bCount = 0; 
            int cCount = 0; 
            int uCount = 0; 
            int fCount = 0;
            int inx = 0;

            string[] grade = { "A" , "B", "C", "F", "S", "U"};

            for (int i = 1; i <= totalStudents; i++)
            {
                Console.Write($"Type of exam \t: ");
                string type = Console.ReadLine();
                Console.Write($"Exam score \t: ");
                int score = int.Parse(Console.ReadLine());

                if (type.ToLower() == "p") 
                { 
                    pCount++;
                    if (score > 60)
                    {
                        sCount++;
                        inx = 4;
                    }
                    else
                    {
                        uCount++;
                        inx = 5;
                    }
                }
                else if (type.ToLower() == "t")
                {
                    if (score >= 80 && score <= 100)
                    {
                        aCount++;
                        inx = 0;
                    }
                    else if (score >= 60 && score < 80)
                    {
                        bCount++;
                        inx = 1;
                    }
                    else if (score >= 50 && score < 60)
                    {
                        cCount++;
                        inx = 2;
                    }
                    else if (score >= 0 && score < 50)
                    {
                        fCount++;
                        inx = 3;
                    }

                }
                Console.WriteLine($"Exam result \t: {grade[inx]}\n");
            }

            Console.WriteLine("Proposal 3 students:");
            Console.WriteLine($"    S =  {sCount}, U = {uCount}");
            Console.WriteLine("Project 3 students");
            Console.WriteLine($"    A = {aCount}, B = {bCount}, C = {cCount}, F = {fCount}");
        }
    }
}
