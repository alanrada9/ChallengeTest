namespace Application.Common.Exceptions
{
    public class CardBlockedException:Exception
    {
        public CardBlockedException(string message, Exception innerException)
        : base(message, innerException)
        {
        }
        public CardBlockedException(string message)
       : base(message)
        {
        }
    }
}
