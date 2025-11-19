namespace Shop.Client.Services
{
	using Shop.Client.Models;
	using Shop.Client.Models.Requests;
	using Shop.Client.Services.Interfaces;

	public class ProductService(HttpClient httpClient) : IProductService
	{
		public async Task<List<ProductViewModel>> GetTopTenProductsAsync(GetTopTenProductsRequest request)
		{
			HttpResponseMessage response = await httpClient.PostAsJsonAsync($"/api/v1/product/list/top-ten", request);
			response.EnsureSuccessStatusCode();

			List<ProductViewModel>? result = await response.Content.ReadFromJsonAsync<List<ProductViewModel>>();
			return result ?? new List<ProductViewModel>();
		}
	}
}
