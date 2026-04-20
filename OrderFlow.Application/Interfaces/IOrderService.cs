using OrderFlow.Application.DTOs;
using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Queries;

namespace OrderFlow.Application.Interfaces;

public interface IOrderService
{
    Task Create(CreateOrderDto dto);

    Task<List<OrdersDto>> GetAll();

    Task Pay(Guid orderId);

    Task Cancel(Guid orderId);

    Task<decimal> GetTotal(Guid orderId);
}