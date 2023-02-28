using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class User
    {
        public void ValidateFirstName(string firstName)
        {
            Console.WriteLine(">>>Matching First Name: ");
            var regex = "^[A-Z][a-z]{2,}$";
            if (Regex.IsMatch(firstName, regex))
                Console.WriteLine($"{firstName} is correct input");
            else
                Console.WriteLine($"'{firstName}' does not match the pattern");
            Console.WriteLine();
        }
        public void ValidateLastName(string lastName)
        {
            Console.WriteLine(">>>Matching Last Name: ");
            var regex = "^[A-Z][a-z]{2,}$";
            if (Regex.IsMatch(lastName, regex))
                Console.WriteLine($"{lastName} is correct input");
            else
                Console.WriteLine($"'{lastName}' does not match the pattern");
            Console.WriteLine();
        }
        public void ValidateEmail(string email)
        {
            Console.WriteLine(">>>Matching  Email: ");
            var regex = "^[a-zA-Z]{3,}[.+-_]{0,1}[0-9]{0,}[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, regex))
                Console.WriteLine($"{email} is correct input");
            else
                Console.WriteLine($"'{email}' does not match the pattern");
            Console.WriteLine();
        }
        public void ValidatePhoneNumber(string number)
        {
            Console.WriteLine(">>>Matching  Number: ");
            var regex = @"^[0-9]{1,2}\s[0-9]{10}$";
            if (Regex.IsMatch(number, regex))
                Console.WriteLine($"{number} is correct input");
            else
                Console.WriteLine($"'{number}' does not match the pattern");
            Console.WriteLine();
        }
        public void ValidatePasswordRule1(string password)
        {
            Console.WriteLine(">>>Matching  Password: ");
            var regex = @".{8,}$";
            if (Regex.IsMatch(password, regex))
                Console.WriteLine($"{password} is correct input");
            else
                Console.WriteLine($"'{password}' does not match the pattern");
            Console.WriteLine();
        }
        public void ValidatePasswordRule2(string password)
        {
            Console.WriteLine(">>>Matching  Password 2: ");
            var regex = "^(?=.*[A-Z]).{8,}$";
            if (Regex.IsMatch(password, regex))
                Console.WriteLine($"{password} is correct input");
            else
                Console.WriteLine($"'{password}' does not match the pattern");
            Console.WriteLine();
        }
    }
}
