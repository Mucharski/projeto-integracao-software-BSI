using IntegracaoSistemasDeSoftwareAPI.Models;
using IntegracaoSistemasDeSoftwareAPI.Models.Global;

namespace IntegracaoSistemasDeSoftwareAPI.Commands.Output;

public class ListProductsCommandResult : CommandResult
{
    public ListProductsCommandResult(List<Product> products, string message)
    {
        Message = message;
        Products = products;
    }
    public List<Product> Products { get; private set; }
}

