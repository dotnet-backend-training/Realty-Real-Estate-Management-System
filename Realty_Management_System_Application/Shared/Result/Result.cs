namespace Realty_Management_System_Application.Shared.Result
{
    public abstract record Result
    {
        public bool Success { get; }
        public string Message { get; }

        protected Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }

    public record SuccessResult : Result
    {
        public SuccessCode SuccessCode { get; }

        public SuccessResult(SuccessCode successCode, string message = "Success")
            : base(true, message)
        {
            SuccessCode = successCode;
        }

        public static SuccessResult Create(SuccessCode successCode, string message = "Success")
            => new(successCode, message);
    }

    public record SuccessResult<T> : Result
    {
        public T Data { get; }

        public SuccessResult(T data, string message = "Success")
            : base(true, message)
        {
            Data = data;
        }

        public static SuccessResult<T> Create(T data, string message = "Success")
            => new(data, message);
    }

    public record FailResult : Result
    {
        public ErrorCode Code { get; }
        public List<string> Errors { get; }

        public FailResult(ErrorCode code, string message, List<string> errors)
            : base(false, message)
        {
            Code = code;
            Errors = errors;
        }

        public FailResult(ErrorCode code, string message, string error)
            : base(false, message)
        {
            Code = code;
            Errors = [error];
        }

        public static FailResult Create(ErrorCode code, string message, string error)
            => new(code, message, error);

        public static FailResult Create(ErrorCode code, string message, List<string> errors)
            => new(code, message, errors);
    }
}
