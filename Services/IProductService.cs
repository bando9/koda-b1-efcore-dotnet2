using KodaStore.Api.DTOs;
using KodaStore.Api.Models;

namespace KodaStore.Api.Services;

public interface IProductService
{
    Task<IReadOnlyList<ProductResponse>> GetAllAsync(ProductStatusFilter filter,CancellationToken cancellationToken);
    Task<ProductResponse?> GetByCodeAsync(string productCode, CancellationToken cancellationToken);
    Task<ProductResponse?> CreateAsync(ProductRequest request, CancellationToken cancellationToken);
    Task<ProductResponse?> UpdateAsync(string productCode, UpdateProductRequest request, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(string productCode, CancellationToken cancellationToken);

    Task<ToggleActivateResponse?> ToggleStatusActiveAsync(string productCode, CancellationToken cancellationToken);
}