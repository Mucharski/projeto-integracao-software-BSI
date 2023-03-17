using Global.Shared.Generics;

namespace Admin.Domain.Commands.Output;

public class CreateProductCommandResult : GenericCommandResult
{
    public CreateProductCommandResult(string message, bool success)
    {
        Message = message;
        Success = success;
    }
    
}