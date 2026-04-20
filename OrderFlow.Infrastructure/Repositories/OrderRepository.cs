using Microsoft.EntityFrameworkCore;
using OrderFlow.Application.DTOs;
using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Interfaces;
using OrderFlow.Domain.Queries;
using OrderFlow.Infrastructure.Database;

namespace OrderFlow.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly OrderFlowDbContext _context;

    public OrderRepository(OrderFlowDbContext context)
    {
        this._context = context;
    }

    public async Task<List<OrdersDto>> GetAll()
    {
        var result = this._context
            .Set<OrdersDto>()
            .FromSqlRaw(@"
                SELECT DENSE_RANK() OVER (ORDER BY _orders.Id) AS ""NumeroDaCompra"", _orders.Id, _users.Name as ""NomeUser"", _products.Name as ""NomeProduct"", _products.Price, _orderItems.Quantity, _products.Stock, _orders.Status
                    FROM dbo.Users as _users
	                    JOIN dbo.Orders as _orders
	                    ON _users.Id = _orders.UserId
		                    JOIN dbo.OrderItems as _orderItems
		                    ON _orders.Id = _orderItems.OrderId
			                    JOIN dbo.Products as _products
			                    ON _products.Id = _orderItems.ProductId;
            ")
            .ToList();

        return result;
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