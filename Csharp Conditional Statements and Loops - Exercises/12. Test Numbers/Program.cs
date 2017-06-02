using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int cnt = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    cnt++;

                    sum = sum + i * j * 3;

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{cnt} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }


                }
            }
            
                Console.WriteLine($"{cnt} combinations");
                Console.WriteLine($"Sum: {sum}");
            



        }
    }
}
