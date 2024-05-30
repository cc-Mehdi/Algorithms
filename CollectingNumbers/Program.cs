using System;

namespace CollectingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size : ");
            int  n = int.Parse(Console.ReadLine());
            Console.Write("Enter the numbers in the array : ");
            string secondLine = Console.ReadLine();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
                numbers[i] = int.Parse(secondLine.Split()[i]);

            CollectingNumbersMethod(numbers, n);

            Console.ReadKey();
        }

        static void CollectingNumbersMethod(int[] numbers, int n)
        {
            int target = 1, round = 0;
            while(target <= n)
            {
                round++;
                for (int i = 0; i < n; i++)
                {
                    if(numbers[i] == target)
                        target++;
                }
            }

            Console.WriteLine(round);
        }
    }
}
