using Microsoft.EntityFrameworkCore;
using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Interfaces;
using OrderFlow.Infrastructure.Database;

namespace OrderFlow.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly OrderFlowDbContext _context;

    public OrderRepository(OrderFlowDbContext context)
    {
        this._context = context;
    }

    public async Task Add(Order order)
    {
        await this._context.Orders.AddAsync(order);
        await this._context.SaveChangesAsync();
    }

    public async Task<Order> GetById(Guid id)
    {
        return await this._context.Orders
            .Include(x => x.Items)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task Update(Order order)
    {
        this._context.Update(order);
        await this._context.SaveChangesAsync();
    }
}