using System;
using System.Collections;

namespace A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] voteCount = new int[10];
            var vote = new ArrayList();

            int num = 0;
            while (true)
            {
                Console.Write("Input data[{0}] :> ", num + 1);
                int.TryParse(Console.ReadLine(), out int candidateNumber);

                if (candidateNumber == 0)
                {
                    break;
                }

                if (candidateNumber >= 1 && candidateNumber <= 9)
                {
                    vote.Add(candidateNumber);
                    voteCount[candidateNumber]++;
                    num++;
                }
                else
                {
                    Console.WriteLine("Invalid candidate number. Please enter a number between 1 and 9.");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Data from villagers:");

            for (int i = 0; i < num; i++)
            {
                Console.Write(vote[i] + " " );
            }

            Console.WriteLine();

            Console.WriteLine("Score of each applicant:");

            for (int i = 0; i < voteCount.Length; i++)
            {
                Console.Write(voteCount[i] + " ");
            }

            Console.WriteLine();

            int winner = FindWinner(voteCount);
            int runnerUp = FindRunnerUp(voteCount);

            Console.WriteLine($"Head is number: {winner}\tvote_score is {voteCount[winner]}");
            Console.WriteLine($"Assistant is number: {runnerUp}\tvote_score is {voteCount[runnerUp]}");
        }

        static int FindWinner(int[] voteCount)
        {
            int maxVotes = -1;
            int winner = -1;

            for (int i = 1; i < voteCount.Length; i++)
            {
                if (voteCount[i] > maxVotes)
                {
                    maxVotes = voteCount[i];
                    winner = i;
                }
            }

            return winner;
        }

        static int FindRunnerUp(int[] voteCount)
        {
            int maxVotes = -1;
            int runnerUp = -1;

            for (int i = 1; i < voteCount.Length; i++)
            {
                if (voteCount[i] > maxVotes && voteCount[i] < voteCount[FindWinner(voteCount)])
                {
                    maxVotes = voteCount[i];
                    runnerUp = i;
                }
            }

            return runnerUp;
        }
    }
}
