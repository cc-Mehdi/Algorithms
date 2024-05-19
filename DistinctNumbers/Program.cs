using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of numbers : ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers with space in one line (2 3 4 5)");
            Console.Write("Enter numbers : ");
            string firstLine = Console.ReadLine();
            int[] numbers = new int[t];

            for (int i = 0; i < t; i++)
                numbers[i] = int.Parse(firstLine.Split()[i].ToString());

            List<int> resNumbers = new List<int>();
            resNumbers.Add(numbers[0]);
            for (int i = 0; i < t; i++)
            {
                int resCounts = resNumbers.Count;
                for (int j = 0; j < resCounts; j++)
                {
                    if (numbers[i] != resNumbers[j])
                    {
                        if (j + 1 == resCounts)
                        {
                            resNumbers.Add(numbers[i]);
                            break;
                        }
                    }
                    else
                        break;
                }
            }

            Console.WriteLine(resNumbers.Count);
            Console.ReadKey();
        }
    }
}
