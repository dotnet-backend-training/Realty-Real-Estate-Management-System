using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Application.Helpers
{
    public class UserIdentifierHelper
    {
        public static UserIdentifierType DetectIdentifierType(string identifier)
        {
            if (identifier.Contains('@')) return UserIdentifierType.Email;
            else return UserIdentifierType.Username;
        }
    }
}
