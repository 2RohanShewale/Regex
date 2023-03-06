using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class UserRegistrationException:Exception
    {
        public enum UserRegistrationExceptionType
        {
            NullReference,
            Empty
        }
        public UserRegistrationExceptionType Type;
        public UserRegistrationException(UserRegistrationExceptionType type,string message): base(message) 
        {
            Type = type;
        }
    }
}
