namespace Shop.Client.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Shop.Client.Models;
	using Shop.Client.Models.Enumerations;
	using Shop.Client.Models.Requests;
	using Shop.Client.Services.Interfaces;

	public class ProductController(IProductService service) : Controller
	{
		public async Task<IActionResult> Index(SortBy sortBy = SortBy.VolumeSold)
		{
			List<ProductViewModel> products =
				await service.GetTopTenProductsAsync(
					request: new GetTopTenProductsRequest()
					{
						SortBy = sortBy,
					});

			ViewBag.SortBy = sortBy;

			return View(products);
		}
	}
}
