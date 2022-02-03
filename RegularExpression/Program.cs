using System;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegularExpression");
            RegularExpression regularExpression = new RegularExpression();// Creating object for a class
            regularExpression.ValidateFirstName("srikanth"); //calling the function
        }
    }
}
