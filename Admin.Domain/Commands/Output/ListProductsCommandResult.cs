using Admin.Domain.Entities;
using Global.Shared.Generics;

namespace Admin.Domain.Commands.Output;

public class ListProductsCommandResult : GenericCommandResult
{
    public ListProductsCommandResult(List<Product> products, string message, bool success)
    {
        Message = message;
        Products = products;
        Success = success;
    }
    public List<Product> Products { get; private set; }
}

