using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            string hallName = "";


            if (people <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
                if (package == "Gold")
                {
                    price += 750;
                    totalPrice = price - price * 0.1;

                }
                else if (package == "Normal")
                {
                    price += 500;
                    totalPrice = price - price * 0.05;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    totalPrice = price - price * 0.15;
                }
            }
            else if (people <= 100)
            {
                hallName = "Terrace";
                price = 5000;
                if (package == "Gold")
                {
                    price += 750;
                    totalPrice = price - price * 0.1;

                }
                else if (package == "Normal")
                {
                    price += 500;
                    totalPrice = price - price * 0.05;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    totalPrice = price - price * 0.15;
                }
            }
            else if (people <= 120)
            {
                hallName = "Great Hall";
                price = 7500;
                if (package == "Gold")
                {
                    price += 750;
                    totalPrice = price - price * 0.1;

                }
                else if (package == "Normal")
                {
                    price += 500;
                    totalPrice = price - price * 0.05;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    totalPrice = price - price * 0.15;
                }


            }           
            else if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            totalPrice = totalPrice / people;
            Console.WriteLine($"We can offer you the { hallName}");
            Console.WriteLine($"The price per person is {totalPrice:f2}$");
        }
    }
}
