﻿using System.ComponentModel.DataAnnotations;

namespace IntegracaoSistemasDeSoftwareAPI.Commands.Input;

public class UpdateProductCommand
{
    [Required] public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}