using MainSpringBridge.Domain.Entities;

namespace MainSpringBridge.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
}
