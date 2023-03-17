using Global.Shared.Generics;

namespace Admin.Domain.Commands.Output;

public class DeleteProductCommandResult : GenericCommandResult
{
    public DeleteProductCommandResult(string message, bool success)
    {
        Message = message;
        Success = success;
    }
}