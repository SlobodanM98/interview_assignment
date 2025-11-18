namespace Shop.Api.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Shop.Contracts.Order.Requests;
	using Shop.Contracts.Order.Services;

	[Route("api/v1/order")]
	public class OrderController(IOrderService orderService) : ExtendedApiController
	{
		[HttpPost("list/open")]
		public async Task<IActionResult> GetOpenOrders([FromBody]GetOpenOrdersRequest request)
		{
			return OkOrError(
				await orderService.GetOpenOrders(request));
		}
	}
}
