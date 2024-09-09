using System.Security.Cryptography;

namespace BusinessLogic.Helpers
{
    public static class RandomHelper
    {
        /// <summary>
        /// generates a random string of digits and latin letters of a given length
        /// </summary>
        /// <param name="length">string length</param>
        /// <returns>a random string of digits of a given length</returns>
        public static string RandomLatinString(int length)
        {
            //const string chars = "1234567890";
            const string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomNumberGenerator.GetInt32(s.Length)]).ToArray());
        }
    }
}
