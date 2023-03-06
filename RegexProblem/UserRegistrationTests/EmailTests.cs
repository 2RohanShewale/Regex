using System;
using System.Collections.Generic;
using RegexProblem;

namespace UserRegistrationTests
{
    internal class EmailTests
    {
        User user = new User();
        [Test]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                user.ValidateEmail("");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("String is empty",ex.Message);
            }
        }
        [Test]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                user.ValidateEmail(null);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Email is null", ex.Message);
            }
        }
    }
}
