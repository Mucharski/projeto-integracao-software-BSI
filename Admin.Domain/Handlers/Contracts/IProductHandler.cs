using Admin.Domain.Commands.Input;
using Global.Shared.Handler;

namespace Admin.Domain.Handlers.Contracts;

public interface IProductHandler : IHandler<CreateProductCommand>, IHandler<UpdateProductCommand>,
    IHandler<ListProductsCommand>, IHandler<DeleteProductCommand>
{
    
}