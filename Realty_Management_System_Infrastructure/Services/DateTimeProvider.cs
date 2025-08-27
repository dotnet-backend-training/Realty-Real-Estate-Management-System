using Realty_Management_System_Application.Shared.Services;

namespace Realty_Management_System_Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
