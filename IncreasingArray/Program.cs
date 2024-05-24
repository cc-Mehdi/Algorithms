using System;

namespace IncreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array items count : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter each array item : ");
            string firstLine = Console.ReadLine();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(firstLine.Split()[i]);

            Console.WriteLine(IncreaseArray(arr));

            Console.ReadKey();
        }

        static int IncreaseArray(int[] arr)
        {
            int steps = 0;

            for (int i = 1; i < arr.Length; i++)
                if(arr[i-1] > arr[i])
                    steps += arr[i-1] - arr[i];

            return steps;
        }
    }
}
