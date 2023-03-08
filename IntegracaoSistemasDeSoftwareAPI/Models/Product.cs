using System.ComponentModel.DataAnnotations;
using IntegracaoSistemasDeSoftwareAPI.Commands.Input;

namespace IntegracaoSistemasDeSoftwareAPI.Models;

public class Product
{
    public Product()
    {
        
    }
    public Product(CreateProductCommand command)
    {
        Name = command.Name;
        Description = command.Description;
        Price = command.Price;
    }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
}