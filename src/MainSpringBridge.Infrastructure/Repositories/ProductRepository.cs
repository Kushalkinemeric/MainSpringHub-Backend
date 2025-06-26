using Dapper;
using MainSpringBridge1.Application.Interfaces;
using MainSpringBridge1.Domain.Entities;
using MainSpringBridge1.Infrastructure.Database;

namespace MainSpringBridge1.Infrastructure.Repositories;

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
