using IntegracaoSistemasDeSoftwareAPI.Models.Global;

namespace IntegracaoSistemasDeSoftwareAPI.Commands.Output;

public class DeleteProductCommandResult : CommandResult
{
    public DeleteProductCommandResult(string message)
    {
        Message = message;
    }
}