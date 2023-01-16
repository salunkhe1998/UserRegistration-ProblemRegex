using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex UC 4 Mobile Number");

            Console.WriteLine("Enter Mobile Number");

            string mobileNo = Console.ReadLine();


            if (Regex.Match(mobileNo, @"^([0-9]{2})\s([0-9]{10})$").Success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}