namespace Realty_Management_System_Application.DTO_s.Auth.Register
{
    public class RegisterResponseDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public IEnumerable<string> RoleNames { get; set; } = new HashSet<string>();
        public required string AccessToken { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string? RefreshToken { get; set; }
    }
}
