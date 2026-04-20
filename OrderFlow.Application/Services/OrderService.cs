using OrderFlow.Domain.Entities;
using OrderFlow.Application.DTOs;
using OrderFlow.Application.Interfaces;
using OrderFlow.Domain.Interfaces;
using OrderFlow.Domain.Queries;

namespace OrderFlow.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;

    public OrderService(IOrderRepository repository, IProductRepository productRepository)
    {
        this._orderRepository = repository;
        this._productRepository = productRepository;
    }
    public async Task Create(CreateOrderDto dto)
    {
        var order = new Order(dto.UserId);

        foreach (var item in dto.Items)
        {
            var product = await this._productRepository.GetById(item.ProductId);

            var orderItem = new OrderItem(
                product.Id,
                item.Quantity,
                product.Price
            );

            order.AddItem(orderItem);
        }

        await this._orderRepository.Add(order);
    }

    public async Task<List<OrdersDto>> GetAll()
    {
        var orders = await this._orderRepository.GetAll();

        return orders.Select(x => new OrdersDto
        {
            NumeroDaCompra = x.NumeroDaCompra,
            Id = x.Id,
            NomeUser = x.NomeUser,
            NomeProduct = x.NomeProduct,
            Price = x.Price,
            Quantity = x.Quantity,
            Stock = x.Stock,
            Status = x.Status
        }).ToList();
    }

    public async Task Pay(Guid orderId)
    {
        var order = await this._orderRepository.GetById(orderId);

        order.MarkAsPaid();

        await this._orderRepository.Update(order);
    }

    public async Task Cancel(Guid orderId)
    {
        var order = await this._orderRepository.GetById(orderId);

        order.Cancel();

        await this._orderRepository.Update(order);
    }

    public async Task<decimal> GetTotal(Guid orderId)
    {
        var order = await this._orderRepository.GetById(orderId);

        return order.GetTotal();
    }
}