using MainSpringBridge1.Domain.Entities;

namespace MainSpringBridge1.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
}
