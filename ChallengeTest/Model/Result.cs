namespace ChallengeTest.Model
{
    public class Result<T>
    {
        public T? Value { get; }
        public bool Success { get; }
        public string? ErrorMessage { get; }

        protected internal Result(T value)
        {
            Value = value;
            Success = true;
            ErrorMessage = null;
        }

        protected internal Result(bool success, string errorMessage)
        {
            Success = success;
            ErrorMessage = errorMessage;
            Value = default;
        }

        public static Result<T> SuccessResult(T value) => new Result<T>(value);

        public static Result<T> ErrorResult(string errorMessage) => new Result<T>(false, errorMessage);

        public static implicit operator Result<T>(T obj) => SuccessResult(obj);

        public static implicit operator Result<T>(string errorMessage) => ErrorResult(errorMessage);
    }
}