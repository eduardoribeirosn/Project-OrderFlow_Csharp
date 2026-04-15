namespace OrderFlow.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Stock {  get; private set; }

    public Product() { }
    
    public Product(string name, decimal price, int stock)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Price = price;
        this.Stock = stock;
    }
}