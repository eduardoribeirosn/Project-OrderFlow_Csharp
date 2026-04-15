using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Enums;

namespace OrderFlow.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public List<OrderItem> Items { get; private set; }
    public OrderStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Order() { }
    
    public Order(Guid userId)
    {
        this.Id = Guid.NewGuid();
        this.UserId = userId;
        this.Items = new List<OrderItem> ();
        this.Status = OrderStatus.Created;
        this.CreatedAt = DateTime.UtcNow;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public decimal GetTotal()
    {
        return this.Items.Sum(x => x.GetTotal());
    }

    public void MarkAsPaid()
    {
        Status = OrderStatus.Paid;
    }

    public void Cancel()
    {
        Status = OrderStatus.Cancelled;
    }
}