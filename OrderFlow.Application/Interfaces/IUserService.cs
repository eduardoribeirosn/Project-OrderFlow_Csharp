using OrderFlow.Application.DTOs;

namespace OrderFlow.Application.Interfaces;

public interface IUserService
{
    Task Create(UserDto dto);

    Task<List<UserDto>> GetAll();
}