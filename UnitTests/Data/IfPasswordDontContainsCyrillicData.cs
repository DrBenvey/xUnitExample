using BusinessLogic.Helpers;

namespace UnitTests.Data
{
    public class IfPasswordDontContainsCyrillicData : TheoryData<bool, bool>
    {
        public IfPasswordDontContainsCyrillicData()
        {
            Add(ValidationHelper.IfPasswordDontContainsCyrillic("dr_Benvey_1996"), true);
            Add(ValidationHelper.IfPasswordDontContainsCyrillic("п"), false);
            Add(ValidationHelper.IfPasswordDontContainsCyrillic("Ж"), false);
            Add(ValidationHelper.IfPasswordDontContainsCyrillic("gП"), false);
            Add(ValidationHelper.IfPasswordDontContainsCyrillic("愛してます"), true);
        }
    }
}
