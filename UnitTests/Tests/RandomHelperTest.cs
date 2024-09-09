using BusinessLogic.Helpers;
using System.Text.RegularExpressions;

namespace UnitTests.Tests
{
    public class RandomHelperTest
    {
        [Fact]
        public void RandomLatinStringTest()
        {
            var randomString = RandomHelper.RandomLatinString(132);
            bool cond1 = randomString.Length == 132;
            bool cond2 = Regex.IsMatch(randomString, "^[a-zA-Z]*$", RegexOptions.IgnoreCase | RegexOptions.NonBacktracking);
            Assert.True(cond1 && cond2);
        }
    }
}
