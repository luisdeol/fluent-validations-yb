using System.Text.RegularExpressions;

namespace SchoolManager.API
{
    public static class StringExtensions
    {
        public static bool IsValidDocument(this string document) {
            var expression = "[0-9]{3}\\.?[0-9]{3}\\.?[0-9]{3}\\-?[0-9]{2}";

            return Regex.Match(document, expression).Success;
        }
    }
}