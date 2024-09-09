using BusinessLogic.Models;
using BusinessLogic.Extensions;

namespace UnitTests.Data
{
    public class TestSpecialSortData : TheoryData<IEnumerable<AvalibleSlotModel>, IEnumerable<AvalibleSlotModel>>
    {
        public TestSpecialSortData() 
        {
            Add(
                new List<AvalibleSlotModel> 
                {
                    new AvalibleSlotModel(new DateTime(2025,11,2,2,2,2,DateTimeKind.Utc)),
                    new AvalibleSlotModel(new DateTime(2024,11,2,2,2,2,DateTimeKind.Utc))
                }.AsSpecialSort(),
                new List<AvalibleSlotModel>
                {
                    new AvalibleSlotModel(new DateTime(2024,11,2,2,2,2,DateTimeKind.Utc)),
                    new AvalibleSlotModel(new DateTime(2025,11,2,2,2,2,DateTimeKind.Utc))
                });
        }
    }
}
