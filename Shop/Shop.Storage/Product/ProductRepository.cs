namespace Shop.Storage.Product
{
	using Microsoft.EntityFrameworkCore;
	using Shop.Contracts.Product.Enumerations;
	using Shop.Contracts.Product.Repositories;
	using Shop.Contracts.Product.Responses;
	using Shop.Storage.Context;
	using Shop.Storage.OrderItem;

	public class ProductRepository(ShopDbContext dbContext) : IProductRepository
	{
		public async Task<IEnumerable<ProductDto>> GetTopTenProducts(SortBy? sortBy)
		{
			IQueryable<ProductDto> topTenProductsQuery =
				dbContext.Set<OrderItem>()
					.AsNoTracking()
					.Where(x => x.DeletedOn == null && x.Product.DeletedOn == null)
					.GroupBy(x => new
					{
						x.ProductId,
						x.Product.Name,
						x.Product.Price,
						x.Product.CreatedOn
					})
					.Select(g => new ProductDto
					{
						Name = g.Key.Name,
						CurrentPrice = g.Key.Price,
						CreatedOn = g.Key.CreatedOn,
						VolumeSold = g.Sum(x => x.Quantity),
						TotalDollarAmountSold = g.Sum(x => x.Quantity * x.Price)
					});

			switch (sortBy)
			{
				case SortBy.DollarAmountSold:
					topTenProductsQuery = topTenProductsQuery.OrderByDescending(x => x.TotalDollarAmountSold);
					break;
				default:
					topTenProductsQuery = topTenProductsQuery.OrderByDescending(x => x.VolumeSold);
					break;
			}

			return await topTenProductsQuery.Take(10).ToArrayAsync();
		}
	}
}
