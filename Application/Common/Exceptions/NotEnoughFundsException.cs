namespace Application.Common.Exceptions
{
    public class NotEnoughFundsException : Exception
    {
        public NotEnoughFundsException(string message, Exception innerException)
        : base(message, innerException)
        {
        }
        public NotEnoughFundsException(string message)
       : base(message)
        {
        }
    }
}
