using BusinessLogic.Models;
using UnitTests.Data;

namespace UnitTests.Tests
{
    public class AvalibleSlotTest
    {
        [Theory]
        [ClassData(typeof(TestSpecialSortData))]
        public void TestSpecialSort(IEnumerable<AvalibleSlotModel> InCode, IEnumerable<AvalibleSlotModel> InReal)
        {
            Assert.Equal(InReal, InCode);
        }

        [Fact]
        public void TestEqual()
        {
            var t1 = new AvalibleSlotModel(new DateTime(2024,11,1,13,34,0,DateTimeKind.Utc));
            var t2 = new AvalibleSlotModel(
                new DateTime(2024, 11, 1, 13, 34, 0, DateTimeKind.Utc),
                new DateTime(2024, 11, 2, 13, 34, 0, DateTimeKind.Utc));
            Assert.Equal(t1, t2);
        }

        [Fact]
        public void TestNotEqual()
        {
            var t1 = new AvalibleSlotModel(
                new DateTime(2024, 11, 1, 13, 34, 0, DateTimeKind.Utc),
                new DateTime(2024, 11, 2, 13, 34, 0, DateTimeKind.Utc));
            var t2 = new AvalibleSlotModel(
                new DateTime(2024, 11, 1, 13, 34, 0, DateTimeKind.Utc),
                new DateTime(2024, 12, 2, 13, 34, 33, DateTimeKind.Utc));
            Assert.NotEqual(t1, t2);
        }
    }
}
