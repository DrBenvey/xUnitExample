using System.Text.RegularExpressions;

namespace BusinessLogic.Helpers
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Check if password contains cyrillic
        /// </summary>
        public static bool IfPasswordDontContainsCyrillic(string password)
        {
            if (Regex.IsMatch(password, @"[а-я]", RegexOptions.IgnoreCase | RegexOptions.NonBacktracking))
                return false;
            return true;
        }
    }
}
