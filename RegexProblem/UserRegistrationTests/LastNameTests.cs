using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegexProblem;
namespace UserRegistrationTests
{
    public class LastNameTests
    {
        User user = new User();
        [Test]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                user.ValidateLastName("");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("String is empty",ex.Message);
            }
        }
        [Test]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                user.ValidateLastName(null);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("LastName is null", ex.Message);
            }
        }
    }
}
