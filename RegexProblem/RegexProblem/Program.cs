using System;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-----REGEX-----*");
            User user = new User();
            user.ValidateFirstName("Rohan");
            user.ValidateLastName("Shewale");
            user.ValidateEmail("shewalerohan50@gmail.com");
            user.ValidatePhoneNumber("91 0123456789");
            user.ValidatePasswordRule1("1234567898");

            Console.ReadKey();
        }
    }
}
