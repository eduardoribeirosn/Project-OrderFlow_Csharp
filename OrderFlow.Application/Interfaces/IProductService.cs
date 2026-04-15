using OrderFlow.Application.DTOs;

namespace OrderFlow.Application.Interfaces;

public interface IProductService
{
    Task Create(ProductDto dto);

    Task<List<ProductDto>> GetAll();
}