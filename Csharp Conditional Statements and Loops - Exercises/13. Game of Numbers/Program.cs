using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int cnt = 0;
            int magicNumberCounter = 0;

            int firstNumber = 0;
            int lastNumber = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    cnt++;

                    if (i + j == magicNumber)
                    {

                        magicNumberCounter++;
                        firstNumber = i;
                        lastNumber = j;
                    }
                    
                }
            }
            if (magicNumberCounter == 0)
            {
                Console.WriteLine($"{cnt} combinations - neither equals {magicNumber}");
            }
            else
            {
            Console.WriteLine($"Number found! {firstNumber} + {lastNumber} = {magicNumber}");

            }
        
        }
    }
}
