using System;

namespace NearestSmallerValues
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the array values : ");
            string firstLine = Console.ReadLine();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
                numbers[i] = int.Parse(firstLine.Split()[i]);

            FindNearestSmallerValues(numbers);

            Console.ReadKey();
        }

        static void FindNearestSmallerValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if(numbers[i] > numbers[j])
                    {
                        Console.Write(j+1 + " ");
                        break;
                    }
                    else if (j-1 < 0)
                        Console.Write("0 ");
                }
            }
        }
    }
}
