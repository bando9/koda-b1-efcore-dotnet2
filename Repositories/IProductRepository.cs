using KodaStore.Api.Models;

namespace KodaStore.Api.Repositories;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetAllAsync(ProductStatusFilter filter,CancellationToken cancellationToken);

    Task<Product?> GetByCodeAsync(string productCode, CancellationToken cancellationToken);
    Task<Product?> GetByCodeChangeAsync(string productCode, CancellationToken cancellationToken);

    Task<bool> TryAddAsync(Product product, CancellationToken cancellationToken);
    Task<bool> TryUpdateAsync(Product product, CancellationToken cancellationToken);

    Task<bool> TryDeleteAsync(string productCode, CancellationToken cancellationToken);

    Task SaveChangeAsync(CancellationToken cancellationToken);


}