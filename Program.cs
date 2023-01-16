using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex User Registration Problem");
            Console.WriteLine("Regex User Registration First Name");
            Console.WriteLine("Enter first Name");

            string text = Console.ReadLine();
            //check the given input contain

            if (Regex.Match(text, "^[A-Z][a-z]{3}$").Success)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}