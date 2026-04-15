using Microsoft.EntityFrameworkCore;
using OrderFlow.Domain.Entities;
using OrderFlow.Domain.Interfaces;
using OrderFlow.Infrastructure.Database;

namespace OrderFlow.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly OrderFlowDbContext _context;

    public ProductRepository(OrderFlowDbContext context)
    {
        this._context = context;
    }

    public async Task Add(Product product)
    {
        await this._context.Products.AddAsync(product);
        await this._context.SaveChangesAsync();
    }

    public async Task<List<Product>> GetAll()
    {
        return await this._context.Products.ToListAsync();
    }

    public async Task<Product> GetById(Guid id)
    {
        return await this._context.Products.FirstOrDefaultAsync(x => x.Id == id);
    }
}