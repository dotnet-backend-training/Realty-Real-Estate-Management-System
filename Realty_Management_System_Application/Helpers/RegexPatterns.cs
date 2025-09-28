using System.Text.RegularExpressions;

namespace Realty_Management_System_Application.Helpers
{
    public static partial class RegexPatterns
    {
        /// <summary>
        /// Returns a compile-time generated <see cref="Regex"/> for validating usernames.
        /// Rules:
        /// - Only letters (a-z, A-Z), numbers (0-9), underscores (_) and dots (.) are allowed.
        /// - Length must be between 3 and 20 characters.
        /// </summary>
        [GeneratedRegex(@"^[a-zA-Z0-9_.]{3,20}$")]
        public static partial Regex UsernameRegex();
    }
}
