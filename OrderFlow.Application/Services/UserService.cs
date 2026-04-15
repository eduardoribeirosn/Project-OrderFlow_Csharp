using OrderFlow.Domain.Entities;
using OrderFlow.Application.DTOs;
using OrderFlow.Application.Interfaces;
using OrderFlow.Domain.Interfaces;

namespace OrderFlow.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        this._repository = repository;
    }
    public async Task Create(UserDto dto)
    {
        var user = new User(dto.Name, dto.Email);

        await this._repository.Add(user);
    }

    public async Task<List<UserDto>> GetAll()
    {
        var users = await this._repository.GetAll();

        return users.Select(x => new UserDto
        {
            Name = x.Name,
            Email = x.Email
        }).ToList();
    }
}