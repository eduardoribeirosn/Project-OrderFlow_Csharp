using Microsoft.EntityFrameworkCore;
using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Interfaces;
using OrderFlow.Infrastructure.Database;

namespace OrderFlow.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly OrderFlowDbContext _context;

    public UserRepository(OrderFlowDbContext context)
    {
        this._context = context;
    }

    public async Task Add(User user)
    {
        await this._context.Users.AddAsync(user);
        await this._context.SaveChangesAsync();
    }

    public async Task<List<User>> GetAll()
    {
        return await this._context.Users.ToListAsync();
    }
}