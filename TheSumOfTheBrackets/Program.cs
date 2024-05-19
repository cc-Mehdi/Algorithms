using System;

namespace TheSumOfTheBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Console.Write("Enter number : ");
            t = int.Parse(Console.ReadLine());
            int[] n = new int[t], results = new int[t];
            double[] x = new double[t];

            for (int i = 0; i < t; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
                x[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < t; i++)
                Console.WriteLine(Math.Floor(n[i] * x[i]));

            Console.ReadKey();
        }
    }
}
