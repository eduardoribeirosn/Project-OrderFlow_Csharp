using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrderFlow.Infrastructure.Database;

namespace OrderFlow.Infrastructure;

public class OrderFlowDbContextFactory : IDesignTimeDbContextFactory<OrderFlowDbContext>
{
    public OrderFlowDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<OrderFlowDbContext>();

        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OrderFlowDb;Trusted_Connection=True;TrustServerCertificate=True");

        return new OrderFlowDbContext(optionsBuilder.Options);
    }
}