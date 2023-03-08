using IntegracaoSistemasDeSoftwareAPI.Commands.Input;
using IntegracaoSistemasDeSoftwareAPI.Models;

namespace IntegracaoSistemasDeSoftwareAPI.Repository.Interfaces;

public interface IProductRepository
{
   public Task<int> Create(Product product);
   public Task<List<Product>> List();
   public Task<int> Update(UpdateProductCommand command);
   public Task<int> Delete(int id);
}