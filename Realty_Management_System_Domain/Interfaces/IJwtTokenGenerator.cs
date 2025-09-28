using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Domain.Interfaces
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateAccessTokenAsync(User user);
    }
}
