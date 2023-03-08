using IntegracaoSistemasDeSoftwareAPI.Commands.Input;
using IntegracaoSistemasDeSoftwareAPI.Commands.Output;
using IntegracaoSistemasDeSoftwareAPI.Models;
using IntegracaoSistemasDeSoftwareAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoSistemasDeSoftwareAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    [Route("Create")]
    public async Task<IActionResult> Create([FromBody] CreateProductCommand command)
    {
        try
        {
            Product product = new(command);

            int rowsAffected = await _repository.Create(product);

            if (rowsAffected == 0)
            {
                return BadRequest(new
                    CreateProductCommandResult("Houve um erro ao adicionar o produto"));
            }

            return Ok(new CreateProductCommandResult("Produto adicionado com sucesso!"));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> List()
    {
        try
        {
            List<Product> productsList = await _repository.List();

            return Ok(new ListProductsCommandResult(productsList,
                "Lista retornada com sucesso!"));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateProductCommand command)
    {
        try
        {
            int rowsAffected = await _repository.Update(command);

            if (rowsAffected == 0)
            {
                return BadRequest(new UpdateProductCommandResult("Não foi possível atualizar o registro."));
            }

            return Ok(new UpdateProductCommandResult("Registro atualizado com sucesso"));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    [HttpDelete]
    [Route("Delete")]
    public async Task<IActionResult> Delete([FromQuery] int id)
    {
        try
        {
            int rowsAffected = await _repository.Delete(id);

            if (rowsAffected == 0)
            {
                return BadRequest(new DeleteProductCommandResult("Não foi possível excluir o registro"));
            }

            return Ok(new DeleteProductCommandResult("Produto excluído com sucesso"));
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}