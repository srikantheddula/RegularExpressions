using System;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegularExpression");
            RegularExpression regularExpression = new RegularExpression();// Creating object for a class
            regularExpression.ValidateFirstName("Srikanth"); //calling the function
            regularExpression.ValidateLastName("Eddula");
            regularExpression.ValidateEmailAddress("xyz@bl.com");
            regularExpression.ValidateMobileNum("+91 2545624545");
            regularExpression.ValidatePassWord("ssssss");
        }
    }
}
