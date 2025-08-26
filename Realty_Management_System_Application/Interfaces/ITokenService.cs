namespace Realty_Management_System_Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateAccessToken(Guid userId, string userName, string firstName, string lastName);
    }
}
