//Var Declaration in C# with int, string, bool types.
using System;
namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables of different data types
            int age = 19; // Integer
            string name = "Vishal"; // String
            bool isStudent = true; // Boolean

            // Outputting the values of the variables to the console
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Student: " + isStudent);

            // Changing the value of the age variable
            age = 21; // Updated age
            Console.WriteLine("Updated Age: " + age);

            // Example of arithmetic operation
            int yearsUntilGraduation = 4; // Assuming 4 years until graduation
            int graduationYear = age + yearsUntilGraduation;
            Console.WriteLine("Expected Graduation Year: " + graduationYear);
        }
    }
}