namespace Realty_Management_System_Application.DTO_s.Auth
{
    public class LoginResponseDto
    {
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public IEnumerable<string> Roles { get; set; } = new HashSet<string>();
        public required string AccessToken { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string? RefreshToken { get; set; }
    }
}
