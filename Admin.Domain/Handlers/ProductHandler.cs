using Admin.Domain.Commands.Input;
using Admin.Domain.Commands.Output;
using Admin.Domain.Entities;
using Admin.Domain.Handlers.Contracts;
using Admin.Domain.Repositories;
using Global.Shared.Generics;

namespace Admin.Domain.Handlers;

public class ProductHandler : IProductHandler
{
    private readonly IProductRepository _repository;
    
    public ProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }
    public async Task<GenericCommandResult> Handle(CreateProductCommand command)
    {
        Product product = new(command);

        int rowsAffected = await _repository.Create(product);

        if (rowsAffected == 0)
        {
            return new
                CreateProductCommandResult("Houve um erro ao adicionar o produto", false);
        }

        return new CreateProductCommandResult("Produto adicionado com sucesso!", true);
    }

    public async Task<GenericCommandResult> Handle(UpdateProductCommand command)
    {
        int rowsAffected = await _repository.Update(command);

        if (rowsAffected == 0)
        {
            return new UpdateProductCommandResult("Não foi possível atualizar o registro.", false);
        }

        return new UpdateProductCommandResult("Registro atualizado com sucesso", true);
    }

    public async Task<GenericCommandResult> Handle(ListProductsCommand command)
    {
        List<Product> productsList = await _repository.List();

        return new ListProductsCommandResult(productsList, 
            "Produtos retornados com sucesso",
            true);
    }

    public async Task<GenericCommandResult> Handle(DeleteProductCommand command)
    {
        int rowsAffected = await _repository.Delete(command.Id);

        if (rowsAffected == 0)
        {
            return new DeleteProductCommandResult("Não foi possível excluir o registro", false);
        }

        return new DeleteProductCommandResult("Produto excluído com sucesso", true);
    }
}