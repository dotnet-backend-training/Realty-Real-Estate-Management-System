namespace Realty_Management_System_Application.Shared
{
    public enum ErrorCode
    {
        None = 0,

        // Auth-related
        UserNotFound = 1,
        InvalidPassword = 2,
        AccountLocked = 3,
        TokenExpired = 4,
        LoginFailed = 5,

        // Validation
        ValidationFailed = 1000,
        MissingRequiredField = 1001,
    }
}
