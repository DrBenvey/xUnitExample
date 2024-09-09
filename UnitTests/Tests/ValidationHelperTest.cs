using UnitTests.Data;

namespace UnitTests.Tests
{
    public class ValidationHelperTest
    {
        [Theory]
        [ClassData(typeof(IfPasswordDontContainsCyrillicData))]
        public void IfPasswordDontContainsCyrillic(bool InCode, bool InReal)
        {
            Assert.Equal(InReal, InCode);
        }
    }
}
