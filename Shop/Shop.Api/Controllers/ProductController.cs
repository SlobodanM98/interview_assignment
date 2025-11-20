namespace Shop.Api.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Shop.Contracts.Product.Requests;
	using Shop.Contracts.Product.Services;

	[Route("api/v1/product")]
	public class ProductController(IProductService productService) : ExtendedApiController
	{
		[HttpPost("list/top-ten")]
		public async Task<IActionResult> GetTopTenProductsAsync([FromBody]GetTopTenProductsRequest request)
		{
			return OkOrError(
				await productService.GetTopTenProducts(request));
		}
	}
}
