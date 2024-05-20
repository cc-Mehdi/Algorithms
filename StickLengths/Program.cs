using System;
using System.Linq;

namespace StickLengths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number : ");
            int n = int.Parse(Console.ReadLine());
            string[] sticks = new string[n];
            sticks = Console.ReadLine().Split().ToArray();

            // sort sticks
            Array.Sort(sticks);

            // get mean of sticks lengths for getting best lengths
            int mean = int.Parse(sticks[n / 2]);

            // change other sticks lengths to best lenghts
            int coasts = 0;
            for (int i = 0; i < sticks.Length; i++)
                coasts += Math.Abs(mean - int.Parse(sticks[i])); // best stick lenght - each stick lengths

            Console.WriteLine(coasts);

            Console.ReadKey();
        }
    }
}
