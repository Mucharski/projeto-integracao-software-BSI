using IntegracaoSistemasDeSoftwareAPI.Models.Global;

namespace IntegracaoSistemasDeSoftwareAPI.Commands.Output;

public class CreateProductCommandResult : CommandResult
{
    public CreateProductCommandResult(string message)
    {
        Message = message;
    }
    
}