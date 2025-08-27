namespace Realty_Management_System_Application.DTO_s.Auth
{
    public class LoginRequestDto
    {
        public required string Identifier { get; set; }
        public required string Password { get; set; }
    }
}
