using System.ComponentModel.DataAnnotations;

namespace IntegracaoSistemasDeSoftwareAPI.Commands.Input;

public class CreateProductCommand
{
    [Required] public string Name { get; set; }
    [Required] public string Description { get; set; }
    [Required] public decimal Price { get; set; }
}