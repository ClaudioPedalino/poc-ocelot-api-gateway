namespace shared
{
    public class Result
    {
        public string Message { get; set; }
        public bool HasError { get; set; }

        public static Result Succes(string message = "")
            => new() { HasError = false, Message = message };

        public static Result Error(string message)
            => new() { HasError = true, Message = message };
    }
}