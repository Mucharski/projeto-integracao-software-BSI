namespace Global.Shared.Generics;

public class GenericCommandResult
{
    public GenericCommandResult() {}
    public GenericCommandResult(string message, bool success)
    {
        Message = message;
        Success = success;
    }
    public string Message { get; set; }
    public bool Success { get; set; }
}