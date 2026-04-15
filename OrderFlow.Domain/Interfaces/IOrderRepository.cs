using OrderFlow.Domain.Entities;

namespace OrderFlow.Domain.Interfaces;

public interface IOrderRepository
{
    Task Add(Order order);

    Task<Order> GetById(Guid id);

    Task Update(Order order);
}