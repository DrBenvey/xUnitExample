namespace BusinessLogic.Models
{
    public class AvalibleSlotModel
    {
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }

        public AvalibleSlotModel(
            DateTime start,DateTime end)
        {
            Start = start;
            End = end;
        }

        public AvalibleSlotModel(
            DateTime start)
        {
            Start=start; 
            End=start.AddDays(1);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            var item = obj as AvalibleSlotModel;

            if (item == null)
                return false;

            return
                Start == item.Start &&
                End == item.End;
        }
        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return $"{Start}-{End}".GetHashCode();
        }
    }
}
