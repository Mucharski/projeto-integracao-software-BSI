using Global.Shared.Generics;

namespace Admin.Domain.Commands.Output;

public class UpdateProductCommandResult : GenericCommandResult
{
    public UpdateProductCommandResult(string message, bool success)
    {
        Message = message;
        Success = success;
    }
}