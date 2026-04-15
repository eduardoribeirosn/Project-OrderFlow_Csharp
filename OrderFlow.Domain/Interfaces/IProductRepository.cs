using OrderFlow.Domain.Entities;

namespace OrderFlow.Domain.Interfaces;

public interface IProductRepository
{
    Task Add(Product product);

    Task<List<Product>> GetAll();

    Task<Product> GetById(Guid id);
}