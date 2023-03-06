using System;
using System.Collections.Generic;
using RegexProblem;

namespace UserRegistrationTests
{
    public class PhoneNumberTests
    {
        User user = new User();
        [Test]
        public void Given_Empty_Mobile_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                user.ValidatePhoneNumber("");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("String is empty", ex.Message);
            }
        }
        [Test]
        public void Given_NULL_Mobile_Should_Throw_UserRegistrationException()
        {
            try
            {
                user.ValidatePhoneNumber(null);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Number is null", ex.Message);
            }
        }
    }
}
