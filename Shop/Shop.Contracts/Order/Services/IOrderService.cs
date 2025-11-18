namespace Shop.Contracts.Order.Services
{
	using Shop.Contracts.Common;
	using Shop.Contracts.Order.Requests;
	using Shop.Contracts.Order.Response;

	public interface IOrderService
	{
		Task<Result<IEnumerable<OrderDto>>> GetOpenOrders(GetOpenOrdersRequest request);
	}
}
