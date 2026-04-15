namespace OrderFlow.Domain.Entities;

public class OrderItem
{
    public Guid OrderItemId { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }

    public OrderItem() { }
    public OrderItem(Guid productId, int quantity, decimal price)
    {
        this.OrderItemId = Guid.NewGuid();
        this.ProductId = productId;
        this.Quantity = quantity;
        this.Price = price;
    }

    public decimal GetTotal()
    {
        return this.Price * this.Quantity;
    }
}