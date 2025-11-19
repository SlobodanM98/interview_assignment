namespace Shop.Contracts.Product.Services
{
	using Shop.Contracts.Common;
	using Shop.Contracts.Product.Requests;
	using Shop.Contracts.Product.Responses;

	public interface IProductService
	{
		Task<Result<IEnumerable<ProductDto>>> GetTopTenProducts(GetTopTenProductsRequest request);
	}
}
