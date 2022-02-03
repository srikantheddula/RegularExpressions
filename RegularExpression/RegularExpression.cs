using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class RegularExpression
    {
        public static string FirstName = "^[A-Z][A-Z a-z]{3,}$";

        public static string EmailAddress = @"^([A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3})+)$";

        public void ValidateFirstName(string firstName) // this method is used for validating first name
        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("{0} is valid", firstName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
            }
        }
        public void ValidateLastName(string firstName) // this method is used for validating last name
        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("{0} is valid", firstName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
            }
        }
        public void ValidateEmailAddress(string email)//-Validating the EmailAddres
        {
            if (Regex.IsMatch(email, EmailAddress))
            {
                Console.WriteLine("{0} is valid", email);
            }
            else
            {
                Console.WriteLine("{0} is not valid", email);
            }

        }
    }
}

