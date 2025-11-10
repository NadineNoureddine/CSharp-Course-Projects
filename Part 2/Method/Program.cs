using System;  // We're including the System namespace so we can use basic functions like Console.

namespace MathOperationApp
{
    // This is the class where the magic happens! 
    // We're creating a class called MathOperations where we'll define our method.
    class MathOperations
    {
        // Let's create a method that takes two integers.
        // The method will modify the first integer, perform an operation, and display the second integer.
        public void PerformOperation(int num1, int num2)
        {
            // Here, we're going to modify num1 by adding 10 to it.
            // This is the math operation we're performing on the first integer.
            num1 += 10;  // Add 10 to num1 (you could change this to any math operation).

            // Now, let's print out the second number (num2) to the console.
            // It's nice and simple – just show it to the user.
            Console.WriteLine($"The second number is: {num2}");

            // For debugging or understanding the flow, let's also print the modified value of num1
            // so the user knows how the operation changed it.
            Console.WriteLine($"The first number after operation: {num1}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Time to create an instance of our MathOperations class!
            // This is where we "instantiate" it, or create an object of it.
            MathOperations mathOps = new MathOperations();

            // Let's call our PerformOperation method now.
            // First, we're passing two numbers (e.g., 5 and 20).
            // This will trigger the method inside the MathOperations class.
            mathOps.PerformOperation(5, 20);

            // Now we're going to call the same method again, but this time we're using named parameters.
            // This way, we specify which number is the first and which is the second explicitly.
            mathOps.PerformOperation(num1: 8, num2: 15);

            // Just a nice little end-of-program message to make sure the console doesn't close immediately.
            // It lets the user hit Enter to exit, which is helpful in a console app.
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
