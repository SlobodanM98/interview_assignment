namespace Shop.Contracts.Product.Repositories
{
	using Shop.Contracts.Product.Enumerations;
	using Shop.Contracts.Product.Responses;

	public interface IProductRepository
	{
		Task<IEnumerable<ProductDto>> GetTopTenProducts(SortBy? sortBy);
	}
}
