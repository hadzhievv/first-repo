using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            long cnt = 0;

            do
            {

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                foreach (char symbol in input)
                {

                    if (!char.IsDigit(symbol))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    cnt++;
                }
                
            } while (flag);

            Console.WriteLine(cnt);
        }
    }
}
