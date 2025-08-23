namespace Realty_Management_System_Application.Shared.Result
{
    public abstract record Result
    {
        public bool Success { get; }
        public string Message { get; }
        public int StatusCode { get; }

        protected Result(bool success, int statusCode, string message)
        {
            Success = success;
            Message = message;
            StatusCode = statusCode;
        }
    }

    public record SuccessResult : Result
    {
        public SuccessCode SuccessCode { get; }

        public SuccessResult(int statusCode, string message = "Success")
            : base(true, statusCode, message)
        {
        }

        public static SuccessResult Create(int statusCode, string message = "Success")
            => new(statusCode, message);
    }

    public record SuccessResult<T> : Result
    {
        public T Data { get; }

        public SuccessResult(T data, int statusCode, string message = "Success")
            : base(true, statusCode, message)
        {
            Data = data;
        }

        public static SuccessResult<T> Create(T data, int statusCode, string message = "Success")
            => new(data, statusCode, message);
    }

    public record FailureResult : Result
    {
        public IReadOnlyList<string> Errors { get; }

        public FailureResult(int statusCode, string message, List<string> errors)
            : base(false, statusCode, message)
        {
            Errors = errors.AsReadOnly();
        }

        public FailureResult(int statusCode, string message, string error)
            : base(false, statusCode, message)
        {
            Errors = new List<string> { error }.AsReadOnly();
        }

        public static FailureResult Create(int statusCode, string message, string error)
            => new(statusCode, message, error);

        public static FailureResult Create(int statusCode, string message, List<string> errors)
            => new(statusCode, message, errors);
    }
}
