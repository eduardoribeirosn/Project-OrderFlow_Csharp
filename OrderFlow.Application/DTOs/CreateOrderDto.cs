namespace OrderFlow.Application.DTOs;

public class CreateOrderDto
{
    public Guid UserId { get; set; }
    public List<CreateOrderItemDto> Items { get; set; }
}