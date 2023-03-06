using RegexProblem;
namespace RegistrationProblemTestProject
{
    public class Tests
    {
        User user = new User();
        [Test]
        public void GivenFirstCapitalLetterFirstName_WhenAnalysed_ShouldReturnValidName()
        {
            string expectedResult = "First Name is Valid";
            string actualResult = user.ValidateFirstName("Rohan");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenFirstCapitalLetterLastName_WhenAnalysed_ShouldReturnValidName()
        {
            string expectedResult = "Last Name is Valid";
            string actualResult = user.ValidateLastName("Shewale");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenFirstSmallLetterFirstName_WhenAnalysed_ShouldReturnNotValidName()
        {
            string expectedResult = "First Name is Invalid";
            string actualResult = user.ValidateFirstName("rohan");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenFirstSmallLetterLastName_WhenAnalysed_ShouldReturnNotValidName()
        {
            string expectedResult = "Last Name is not Valid";
            string actualResult = user.ValidateLastName("shewale");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenEmailId_WhenAnalysed_ShouldReturnEmailValid()
        {
            string expectedResult = "Email is Valid";
            string actualResult = user.ValidateEmail("abc@gmail.com");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenMobile10Number_WhenAnalysed_ShouldReturnMobileNumberValid()
        {
            string expectedResult = "Mobile Number is Valid";
            string actualResult = user.ValidatePhoneNumber("91 9869624683");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenMobile9Number_WhenAnalysed_ShouldReturnMobileNumberNotValid()
        {
            string expectedResult = "Mobile Number not Valid";
            string actualResult = user.ValidatePhoneNumber("91 98696245");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8Letters_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = user.ValidatePasswordRule1("rohanshewale");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given7Letters_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password is not Valid";
            string actualResult = user.ValidatePasswordRule1("qwertyu");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCase_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = user.ValidatePasswordRule2("qwerTyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8Letters_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password is not Valid";
            string actualResult = user.ValidatePasswordRule3("qwertyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCaseAndNumberCase_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = user.ValidatePasswordRule3("qwerTyu1");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCase_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password is not Valid";
            string actualResult = user.ValidatePasswordRule3("qwertyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCaseOneNumberCaseOneSpecialCharacter_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = user.ValidatePasswordRule4("qwerTy*1");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCaseOneNumberCase_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password is not Valid";
            string actualResult = user.ValidatePasswordRule4("qwertyu1");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
