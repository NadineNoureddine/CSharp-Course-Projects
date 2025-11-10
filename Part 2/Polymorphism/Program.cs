using System;  // Import the basic System namespace for Console functionality

namespace EmployeeApp
{
    // Define an interface called IQuittable that declares a Quit method.
    // Interfaces define a contract: any class implementing this interface must implement Quit().
    public interface IQuittable
    {
        // The Quit method doesn't take any parameters and doesn't return anything.
        void Quit();
    }

    // Employee class now implements the IQuittable interface.
    // This means that Employee must implement the Quit() method as defined in IQuittable.
    public class Employee : IQuittable
    {
        // Auto-implemented properties: Id, FirstName, LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // The Quit method is implemented here. As part of IQuittable, Employee must provide this method.
        public void Quit()
        {
            // For simplicity, the employee will print a message saying they are quitting.
            Console.WriteLine($"{FirstName} {LastName} has quit the job. Goodbye!");
        }

        // Overloading the "==" operator to compare two Employee objects by their Id property.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both are the same object reference
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one or both are null, return false
            if (emp1 == null || emp2 == null)
                return false;

            // Compare the Id properties for equality
            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator to compare two Employee objects.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);  // Negate the result of "=="
        }

        // Overriding Equals method to be consistent with "==" and "!=" operators.
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Overriding GetHashCode to ensure consistency with Equals.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Main program to demonstrate polymorphism and the IQuittable interface.
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object.
            Employee emp1 = new Employee { Id = 1, FirstName = "Nadine", LastName = "Noureddine" };

            // Create an object of type IQuittable. Even though we use IQuittable, the actual object is of type Employee.
            IQuittable quittableEmployee = emp1;

            // Call the Quit() method using polymorphism. 
            // The IQuittable reference is pointing to an Employee object, and we are calling the Quit() method implemented in Employee.
            quittableEmployee.Quit();  // This will output: John Doe has quit the job. Goodbye!

            // For demonstration, we also call Quit() on the Employee object directly.
            emp1.Quit();  // This will output the same message: John Doe has quit the job. Goodbye!

            // Just to make sure the program doesn't close immediately, wait for the user to press Enter.
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();  // Keeps the console window open until the user presses Enter.
        }
    }
}
