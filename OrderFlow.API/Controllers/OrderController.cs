using Microsoft.AspNetCore.Mvc;
using OrderFlow.Application.DTOs;
using OrderFlow.Application.Interfaces;

namespace OrderFlow.API.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{

    private readonly IOrderService _service;

    public OrderController(IOrderService service)
    {
        this._service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderDto dto)
    {
        await this._service.Create(dto);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var orders = await this._service.GetAll();

        return Ok(orders);
    }

    [HttpPost("{id}/pay")]
    public async Task<IActionResult> Pay(Guid id)
    {
        await this._service.Pay(id);

        return Ok();
    }

    [HttpPost("{id}/cancel")]
    public async Task<IActionResult> Cancel(Guid id)
    {
        await this._service.Cancel(id);

        return Ok();
    }

    [HttpGet("{id}/total")]
    public async Task<IActionResult> GetTotal(Guid id)
    {
        var total = await this._service.GetTotal(id);

        return Ok(total);
    }
}