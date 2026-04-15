using Microsoft.AspNetCore.Mvc;
using OrderFlow.Application.DTOs;
using OrderFlow.Application.Interfaces;

namespace OrderFlow.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        this._service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(UserDto dto)
    {
        await this._service.Create(dto);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await this._service.GetAll();

        return Ok(users);
    }
}