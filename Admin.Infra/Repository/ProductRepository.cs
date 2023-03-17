using Admin.Domain.Commands.Input;
using Admin.Domain.Entities;
using Admin.Domain.Repositories;
using Admin.Infra.Queries;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Admin.Infra.Repository;

public class ProductRepository : IProductRepository
{
    private readonly SqliteConnection _connection = new("Data Source=./dbIntegracaoSistemasDeSoftware.db");
    private readonly ProductQueries _queries;

    public ProductRepository(ProductQueries queries)
    {
        _queries = queries;
    }
    public async Task<int> Create(Product product)
    {
        try
        {
            await _connection.OpenAsync();

            return (await _connection.ExecuteAsync(_queries.CreateProduct(), new
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            }));
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<List<Product>> List()
    {
        try
        {
            await _connection.OpenAsync();

            return Enumerable.ToList((await _connection.QueryAsync<Product>(_queries.ListProducts())));
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> Update(UpdateProductCommand command)
    {
        try
        {
            await _connection.OpenAsync();

            return await _connection.ExecuteAsync(_queries.UpdateProduct(), new
            {
                Id = command.Id,
                Name = command.Name,
                Description = command.Description,
                Price = command.Price
            });
        }
        catch (Exception e)
        {
            throw;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> Delete(int id)
    {
        try
        {
            await _connection.OpenAsync();

            return await _connection.ExecuteAsync(_queries.DeleteProduct(), new
            {
                Id = id,
            });
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }
}