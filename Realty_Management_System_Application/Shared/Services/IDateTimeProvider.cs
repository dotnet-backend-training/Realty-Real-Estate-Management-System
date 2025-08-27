namespace Realty_Management_System_Application.Shared.Services
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}
