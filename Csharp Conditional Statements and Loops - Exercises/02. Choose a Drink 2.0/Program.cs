using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string drink = " ";
            double price = 0;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = n * 0.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffe";
                price = n * 1;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = n * 1.7;

            }
            else
            {
                drink = "Tea";
                price = n * 1.2;

            }

            Console.WriteLine($"The { profession} has to pay {price:f2}.");
        }
    }
}
