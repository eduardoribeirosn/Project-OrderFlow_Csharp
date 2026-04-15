using OrderFlow.Domain.Entities;

namespace OrderFlow.Domain.Interfaces;

public interface IUserRepository
{
    Task Add(User user);

    Task<List<User>> GetAll();
}