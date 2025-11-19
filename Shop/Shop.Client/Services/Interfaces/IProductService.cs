namespace Shop.Client.Services.Interfaces
{
	using Shop.Client.Models;
	using Shop.Client.Models.Requests;

	public interface IProductService
	{
		Task<List<ProductViewModel>> GetTopTenProductsAsync(GetTopTenProductsRequest request);
	}
}
