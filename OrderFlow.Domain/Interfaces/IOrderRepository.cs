using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Queries;

namespace OrderFlow.Domain.Interfaces;

public interface IOrderRepository
{
    Task<List<OrdersDto>> GetAll();
    Task Add(Order order);

    Task<Order> GetById(Guid id);

    Task Update(Order order);
}