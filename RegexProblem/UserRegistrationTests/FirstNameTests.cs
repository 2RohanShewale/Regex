using RegexProblem;
namespace UserRegistrationTests
{
    public class Tests
    {
        User user = new User();

        [Test]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                user.ValidateFirstName("");
            }
            catch (UserRegistrationException obj)
            {
                Assert.AreEqual("String is empty", obj.Message);
            }
            Assert.Pass();
        }
        [Test]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                user.ValidateFirstName(null);
            }
            catch (UserRegistrationException obj)
            {
                Assert.AreEqual("FirstName is null",obj.Message);
            }
        }
    }
}