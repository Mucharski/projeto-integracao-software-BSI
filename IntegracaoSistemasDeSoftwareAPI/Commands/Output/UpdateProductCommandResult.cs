using IntegracaoSistemasDeSoftwareAPI.Models.Global;

namespace IntegracaoSistemasDeSoftwareAPI.Commands.Output;

public class UpdateProductCommandResult : CommandResult
{
    public UpdateProductCommandResult(string message)
    {
        Message = message;
    }
}