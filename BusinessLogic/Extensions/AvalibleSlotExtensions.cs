using BusinessLogic.Models;

namespace BusinessLogic.Extensions
{
    public static class AvalibleSlotExtensions
    {
        public static IEnumerable<AvalibleSlotModel> AsSpecialSort(this IEnumerable<AvalibleSlotModel> input)
        {
            return input.OrderBy(x=>x.Start).ThenBy(x=>x.End);
        }
    }
}
