namespace Realty_Management_System_Application.Interfaces
{
    public interface IAuthService
    {
        public Task LoginAsync(string userIdentifier, string password);
    }
}
