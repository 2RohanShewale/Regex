using System;
using System.Text.RegularExpressions;
using static RegexProblem.UserRegistrationException;

namespace RegexProblem
{
    public class User
    {
        public string ValidateFirstName(string firstName)
        {
            if (firstName == string.Empty)
                throw new UserRegistrationException(UserRegistrationExceptionType.Empty, "String is empty");
            if (firstName == null)
            {
                throw new UserRegistrationException(UserRegistrationExceptionType.NullReference, "FirstName is null");
            }
            Console.WriteLine(">>>Matching First Name: ");
            var regex = "^[A-Z][a-z]{2,}$";
            if (Regex.IsMatch(firstName, regex))
            {
                Console.WriteLine($"{firstName} is correct input");
                return "First Name is Valid";
            }
            else
            {
                Console.WriteLine($"'{firstName}' does not match the pattern");
                return "First Name is Invalid";
            }

        }
        public string ValidateLastName(string lastName)
        {
            if (lastName == string.Empty)
                throw new UserRegistrationException(UserRegistrationExceptionType.Empty, "String is empty");
            if (lastName == null)
                throw new UserRegistrationException(UserRegistrationExceptionType.NullReference, "LastName is null");
            Console.WriteLine(">>>Matching Last Name: ");
            var regex = "^[A-Z][a-z]{2,}$";
            if (Regex.IsMatch(lastName, regex))
            {
                Console.WriteLine($"{lastName} is correct input");
                return "Last Name is Valid";
            }
            else
            {
                Console.WriteLine($"'{lastName}' does not match the pattern");
                return "Last Name is not Valid";
            }
        }
        public string ValidateEmail(string email)
        {
            if (email == string.Empty)
                throw new UserRegistrationException(UserRegistrationExceptionType.Empty, "String is empty");
            if (email == null)
                throw new UserRegistrationException(UserRegistrationExceptionType.NullReference, "Email is null");
            Console.WriteLine(">>>Matching  Email: ");
            var regex = "^[a-zA-Z]{3,}[.+-_]{0,1}[0-9]{0,}[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, regex))
            {
                Console.WriteLine($"{email} is correct input");
                return "Email is Valid"; 
            }
            else
            {
                Console.WriteLine($"'{email}' does not match the pattern");
                return "Email is Not Valid";
            }
        }
        public string ValidatePhoneNumber(string number)
        {
            if (number == string.Empty)
                throw new UserRegistrationException(UserRegistrationExceptionType.Empty, "String is empty");
            if (number == null)
                throw new UserRegistrationException(UserRegistrationExceptionType.NullReference, "Number is null");
            Console.WriteLine(">>>Matching  Number: ");
            var regex = @"^[0-9]{1,2}\s[0-9]{10}$";
            if (Regex.IsMatch(number, regex))
            {
                Console.WriteLine($"{number} is correct input");
                return "Mobile Number is Valid";
            }
            else
            {
                Console.WriteLine($"'{number}' does not match the pattern");
                return "Mobile Number not Valid";
            }
        }
        public string ValidatePasswordRule1(string password)
        {
            Console.WriteLine(">>>Matching  Password: ");
            var regex = @".{8,}$";
            if (Regex.IsMatch(password, regex))
            {
                Console.WriteLine($"{password} is correct input");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine($"'{password}' does not match the pattern");
                return "Password is not Valid";
            }
        }
        public string ValidatePasswordRule2(string password)
        {
            Console.WriteLine(">>>Matching  Password 2: ");
            var regex = "^(?=.*[A-Z]).{8,}$";
            if (Regex.IsMatch(password, regex))
            {
                Console.WriteLine($"{password} is correct input");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine($"'{password}' does not match the pattern");
                return "Password is not Valid";
            }
        }
        public string ValidatePasswordRule3(string password)
        {
            Console.WriteLine(">>>Matching  Password 3: ");
            var regex = "^(?=.*[0-9])(?=.*[A-Z]).{8,}$";
            if (Regex.IsMatch(password, regex))
            {
                Console.WriteLine($"{password} is correct input");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine($"'{password}' does not match the pattern");
                return "Password is not Valid";
            }
        }
        public string ValidatePasswordRule4(string password)
        {
            Console.WriteLine(">>>Matching  Password 4: ");
            var regex = "^(?=.*[!@#$%^&*()-+])(?=.*[0-9])(?=.*[A-Z]).{8,}$";
            if (Regex.IsMatch(password, regex))
            {
                Console.WriteLine($"{password} is correct input");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine($"'{password}' does not match the pattern");
                return "Password is not Valid";
            }
        }
    }
}
