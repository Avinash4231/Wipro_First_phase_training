using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class CustomDefinedException
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above to vote.");
            }
            Console.WriteLine("You are eligible to vote.");
        }

        public static void run()
        {
            try
            {
                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());
                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number for age.");
            }
        }
    }
}
