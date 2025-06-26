using Dapper;
using MainSpringBridge.Application.Interfaces;
using MainSpringBridge.Domain.Entities;
using MainSpringBridge.Infrastructure.Database;

namespace MainSpringBridge.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DbConnectionFactory _dbFactory;

    public ProductRepository(DbConnectionFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var sql = "SELECT * FROM Products";
        using var conn = _dbFactory.CreateConnection();
        return await conn.QueryAsync<Product>(sql);
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        var sql = "SELECT * FROM Products WHERE Id = @Id";
        using var conn = _dbFactory.CreateConnection();
        return await conn.QueryFirstOrDefaultAsync<Product>(sql, new { Id = id });
    }
}
