using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if (i == n - 1)
                    {
                        if (j % 2 == 0)
                            Console.Write("D");
                        else
                            Console.Write(".");
                    }
                    else if (j == n - 1 - i || j == n - 1 + i)
                        Console.Write("D");
                    else
                        Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
