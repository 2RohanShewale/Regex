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

            Console.ReadKey();
        }
    }
}
