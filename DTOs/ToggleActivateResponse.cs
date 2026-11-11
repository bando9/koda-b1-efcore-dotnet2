
using KodaStore.Api.Models;

namespace KodaStore.Api.DTOs;

public sealed record ToggleActivateResponse(
    string ProductCode, string Name, decimal Price, int Stock, string Category, bool IsActive, DateTime? DeactivatedUtc
)
{
    public static ToggleActivateResponse FromModel(Product product) => new(product.ProductCode, product.Name, product.Price, product.Stock, product.Category, product.IsActive, product?.DeactivatedUtc);
}
