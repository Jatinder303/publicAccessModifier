//Here, we declare a class Student which consists of two class members rollNo and name which are public. 
//These members can access from anywhere throughout the code in the current and another assembly in the program.
//The methods getRollNo and getName are also declared as public.

// C# Program to show the use of 
// public Access Modifier 
using System;

namespace publicAccessModifier
{
    static class Program
    {
        // Main Method 
        static void Main(string[] args)
        {
            // Creating object of the class Student 
            Student S = new Student(1, "Jatinder");

            // Displaying details directly 
            // using the class members 
            // accessible through another method 
            Console.WriteLine("Roll number: {0}", S.rollNo);
            Console.WriteLine("Name: {0}", S.name);

            Console.WriteLine();

            // Displaying details using 
            // member method also public 
            Console.WriteLine("Roll number: {0}", S.getRollNo());
            Console.WriteLine("Name: {0}", S.getName());
        }
    }
}
