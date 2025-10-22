using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for package weight
            Console.Write("Please enter the package weight: ");
            // Convert the user input to a decimal (supports decimal values)
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if weight exceeds the maximum allowed
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
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

            // Check if the sum of dimensions exceeds the maximum allowed
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the volume of the package
            decimal volume = width * height * length;

            // Calculate the quote using the formula: (volume * weight) / 100
            decimal quote = (volume * weight) / 100;

            // Display the calculated quote as a formatted dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");
        }
    }
}
