using Admin.Domain.Commands.Input;
using Admin.Domain.Entities;

namespace Admin.Domain.Repositories;

public interface IProductRepository
{
   public Task<int> Create(Product product);
   public Task<List<Product>> List();
   public Task<int> Update(UpdateProductCommand command);
   public Task<int> Delete(int id);
}