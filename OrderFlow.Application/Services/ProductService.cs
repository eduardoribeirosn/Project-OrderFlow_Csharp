using OrderFlow.Domain.Entities;
using OrderFlow.Application.DTOs;
using OrderFlow.Application.Interfaces;
using OrderFlow.Domain.Interfaces;

namespace OrderFlow.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        this._repository = repository;
    }
    public async Task Create(ProductDto dto)
    {
        var product = new Product(dto.Name, dto.Price, dto.Stock);

        await this._repository.Add(product);
    }

    public async Task<List<ProductDto>> GetAll()
    {
        var products = await this._repository.GetAll();

        return products.Select(x => new ProductDto
        {
            Name = x.Name,
            Price = x.Price,
            Stock = x.Stock
        }).ToList();
    }
}