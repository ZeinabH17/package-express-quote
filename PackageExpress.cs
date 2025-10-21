using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shipping Quote Calculator for Package Express

            // First message displayed to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // If the weight is over 50, display an error and stop the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program immediately
            }

            // Prompt the user for package width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user for package height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user for package length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the combined dimensions exceed 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program immediately
            }

            // If both checks pass, calculate the quote:
            // Multiply width * height * length, then multiply by weight, then divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the quote formatted as a dollar amount with 2 decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
            Console.WriteLine("Thank you!");
        }
    }
}

