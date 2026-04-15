using OrderFlow.Application.DTOs;

namespace OrderFlow.Application.Interfaces;

public interface IOrderService
{
    Task Create(CreateOrderDto dto);

    Task Pay(Guid orderId);

    Task Cancel(Guid orderId);

    Task<decimal> GetTotal(Guid orderId);
}