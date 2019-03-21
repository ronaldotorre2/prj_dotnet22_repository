namespace SGC.Shared.Enuns
{
    /// <summary>
    /// Enumeradores de pessoas
    /// </summary>
    public class PersonEnum
    {
        public enum Type
        {
            physical = 1,
            juridical = 2
        }

        public enum Gender
        {
            female = 1,
            male = 2
        }
        
        public enum StateCivil
        {
            single = 1,
            dating = 2,
            engaged = 3,
            Married = 4,
            Separate = 5,
            Divorced = 6,
            Widower = 7,
            Other = 8
        }
    }
}
