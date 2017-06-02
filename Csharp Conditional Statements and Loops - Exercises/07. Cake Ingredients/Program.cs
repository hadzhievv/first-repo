using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            for (int i = 1; i <= 50; i++)
            {
                string ingredients = Console.ReadLine();
                
                if (ingredients == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {cnt} ingredients.");
                    break;                
                }

                cnt++;
                Console.WriteLine($"Adding ingredient {ingredients}.");
            }
        }
    }
}
