﻿using System;
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
            string drink = " ";


            if (profession == "Athlete")
            {
                drink = "Water";
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }

            Console.WriteLine(drink);
        }
    }
}
