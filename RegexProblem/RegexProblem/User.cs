﻿using System;
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
    }
}
