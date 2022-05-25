using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            double discountStudio = 1.0;
            double discountApartment = 1.0;
            if (nights > 14)
            {
                discountApartment = 0.9;
            }
            switch (month)
            {
                case "May":
                case "October":
                    if (nights > 7 && nights <= 14)
                    {
                        discountStudio = 0.95;
                    }
                    else if (nights > 14)
                    {
                        discountStudio = 0.7;
                    }
                    studioPrice = nights * (50.0 * discountStudio);
                    apartmentPrice = nights * (65.0 * discountApartment);
                    break;
                case "June":
                case "September":
                    if (nights > 14)
                    {
                        discountStudio = 0.80;
                    }
                    studioPrice = nights * (75.20 * discountStudio);
                    apartmentPrice = nights * (68.70 * discountApartment);
                    break;
                case "July":
                case "August":
                    studioPrice = nights * (76.0 * discountStudio);
                    apartmentPrice = nights * (77.0 * discountApartment);
                    break; 
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
