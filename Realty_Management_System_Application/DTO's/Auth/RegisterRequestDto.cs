namespace Realty_Management_System_Application.DTO_s.Auth
{
    public class RegisterRequestDto
    {
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ProfileImageUrl { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public Guid ZoneId { get; set; }
    }
}
