using HarryPotterKata.Enumerations;
using HarryPotterKata.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterKata
{
    internal static class UserInput
    {
        public static void Process()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");

            var basket = new Basket();

            foreach (BookVolumeEnum bookVolume in Enum.GetValues(typeof(BookVolumeEnum)))
            {
                Console.Write($"Please enter the quantity for book volume {bookVolume.ToString()} : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int quantity))
                {
                    basket.AddBooks(bookVolume, quantity);
                }
                else
                {
                    Console.WriteLine("Invalid input, we assume quantity 0");
                }
            }


            Console.WriteLine();
            Console.WriteLine($"The total price of the basket is : {basket.TotalPrice}");
            Console.WriteLine("The book combinations in the basket are as following:");
            Console.WriteLine(basket.PrintBookSets());
        }
    }
}
