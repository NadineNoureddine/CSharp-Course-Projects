using System; // Standard namespace to use Console and basic functionality

namespace EmployeeApp
{
    // Employee class with properties: Id, FirstName, and LastName
    public class Employee
    {
        // Auto-implemented properties for Id, FirstName, and LastName
        public int Id { get; set; }      // Employee's ID
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; }  // Employee's last name

        // Overloading the "==" operator to compare two Employee objects
        // It checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are the same reference, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either object is null, they are not equal
            if (emp1 == null || emp2 == null)
                return false;

            // Now we compare by the Id property
            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator to compare two Employee objects
        // This operator must be overloaded as a pair with "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply reverse the result of the "==" operator
            return !(emp1 == emp2);
        }

        // Override the Equals method to maintain consistency with "==" and "!="
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Override GetHashCode to be consistent with Equals method
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Return the hash code based on Id
        }
    }

    // Main program to test the Employee class and operator overloading
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with different IDs
            Employee emp1 = new Employee { Id = 1, FirstName = "Nadine", LastName = "Noureddine" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Yassin", LastName = "Tag" };

            // Compare the two Employee objects using the overloaded "==" operator
            bool areEqual = emp1 == emp2;  // This will compare emp1 and emp2 by their Id

            // Output the comparison result to the console
            Console.WriteLine($"Are the two employees equal? {areEqual}"); // Expected: False

            // Now, let's modify emp2's Id to match emp1's Id and check the comparison again
            emp2.Id = 1;

            // Compare the two Employee objects again using the "==" operator
            areEqual = emp1 == emp2;  // This time, emp1 and emp2 have the same Id

            // Output the updated comparison result to the console
            Console.WriteLine($"Are the two employees equal after Id change? {areEqual}"); // Expected: True

            // Checking the "!=" operator (reverse comparison)
            bool areNotEqual = emp1 != emp2;  // This will check if they are not equal (should be false)
            Console.WriteLine($"Are the two employees not equal? {areNotEqual}"); // Expected: False

            // Just to make sure the program doesn't close immediately, wait for the user to press Enter
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();  // This prevents the console window from closing right after execution
        }
    }
}
