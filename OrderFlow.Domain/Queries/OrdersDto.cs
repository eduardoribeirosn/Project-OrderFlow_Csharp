namespace OrderFlow.Domain.Queries;

public class OrdersDto
{
    public long NumeroDaCompra { get; set; }
    public Guid Id { get; set; }
    public String NomeUser { get; set; } = string.Empty;
    public String NomeProduct { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int Stock { get; set; }
    public int Status { get; set; }
}