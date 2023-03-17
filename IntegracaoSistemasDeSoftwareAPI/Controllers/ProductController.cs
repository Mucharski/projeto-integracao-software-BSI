using Admin.Domain.Commands.Input;
using Admin.Domain.Commands.Output;
using Admin.Domain.Entities;
using Admin.Domain.Handlers.Contracts;
using Admin.Domain.Repositories;
using Global.Shared.Generics;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoSistemasDeSoftwareAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult<GenericCommandResult>> Create([FromServices] IProductHandler handler,
        [FromBody] CreateProductCommand command)
    {
        try
        {
            GenericCommandResult handleResult = await handler.Handle(command);

            return Created("Criado!", handleResult);
        }
        catch (Exception ex)
        {
            ex.Data.Add("Product(Create)", command);
            throw;
        }
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> List([FromServices] IProductHandler handler)
    {
        try
        {
            GenericCommandResult handleResult = await handler.Handle(new ListProductsCommand());

            return Ok(handleResult);
        }
        catch (Exception ex)
        {
            ex.Data.Add("Product(List)", new { });
            throw;
        }
    }

    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Update([FromServices] IProductHandler handler,
        [FromBody] UpdateProductCommand command)
    {
        try
        {
            GenericCommandResult handleResult = await handler.Handle(command);

            return Ok(handleResult);
        }
        catch (Exception ex)
        {
            ex.Data.Add("Product(Update)", command);
            throw;
        }
    }

    [HttpDelete]
    [Route("Delete")]
    public async Task<IActionResult> Delete([FromServices] IProductHandler handler,
        [FromQuery] int id)
    {
        try
        {
            GenericCommandResult handleResult = await handler.Handle(new DeleteProductCommand(id));

            return Ok(handleResult);
        }
        catch (Exception ex)
        {
            ex.Data.Add("Product(Delete)", id);
            throw;
        }
    }
}