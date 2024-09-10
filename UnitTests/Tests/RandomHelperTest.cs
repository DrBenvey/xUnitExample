using BusinessLogic.Helpers;
using System.Text.RegularExpressions;
using Xunit.Abstractions;

namespace UnitTests.Tests
{
    public class RandomHelperTest
    {
        private readonly ITestOutputHelper output;

        public RandomHelperTest(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void RandomLatinStringTest()
        {
            var randomString = RandomHelper.RandomLatinString(132);
            bool cond1 = randomString.Length == 132;
            bool cond2 = Regex.IsMatch(randomString, "^[a-zA-Z]*$", RegexOptions.IgnoreCase | RegexOptions.NonBacktracking);
            output.WriteLine("This is output from {0}", randomString);
            Assert.True(cond1 && cond2);
        }
    }
}
