using Microsoft.AspNetCore.Mvc;
using OrderFlow.Application.DTOs;
using OrderFlow.Application.Interfaces;

namespace OrderFlow.API.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        this._service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductDto dto)
    {
        await this._service.Create(dto);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await this._service.GetAll();

        return Ok(products);
    }
}