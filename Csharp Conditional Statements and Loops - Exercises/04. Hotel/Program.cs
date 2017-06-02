using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;


            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;

                    if (nights > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;

                    if (nights > 14)
                    {
                        doublePrice *= 0.90;
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;

                    if (nights > 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
            }

            double totalStudioPrice = studioPrice * nights;
            double totalDoublePrice = doublePrice * nights;
            double totalSuitePrice = suitePrice * nights;


            if ((month == "September" || month == "October") && nights > 7)
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");


        }
    }
}
