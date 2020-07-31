using System;
using System.Collections.Generic;

namespace _4_5_Lab_Trivia_Leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> trivScores = new List<int>();
            trivScores.Add(4400);
            trivScores.Add(8900);
            trivScores.Add(1200);
            trivScores.Add(3700);
            trivScores.Add(7200);

            Console.WriteLine("the list");
            foreach (int item in trivScores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("the sorted list");
            trivScores.Sort();
            foreach (int item in trivScores)
            {
                Console.WriteLine(item);
            }
            trivScores.Reverse();
            Console.WriteLine("the reverse sorted list");
            foreach (int item in trivScores)
            {
                Console.WriteLine(item);
            }
            // adding and removing score - didn't do the sort thing here - easiest enough to add
            // the code, but will wait until I can call the sort and reverse as a function or library.
            trivScores.Add(2400);
            Console.WriteLine("the added-to list");
            foreach (int item in trivScores)
            {
                Console.WriteLine(item);
            }
            trivScores.Remove(4400);
            Console.WriteLine("the removed-from list");
            foreach (int item in trivScores)
            {
                Console.WriteLine(item);
            }
        }
    }
}
