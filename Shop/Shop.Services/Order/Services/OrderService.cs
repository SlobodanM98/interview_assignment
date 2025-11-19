namespace Shop.Services.Order.Services
{
	using Shop.Contracts.Common;
	using Shop.Contracts.Order.Repositories;
	using Shop.Contracts.Order.Requests;
	using Shop.Contracts.Order.Response;
	using Shop.Contracts.Order.Services;
	using Shop.Domain.Common;

	public class OrderService(IOrderRepository orderRepository) : IOrderService
	{
		public async Task<Result<IEnumerable<OrderDto>>> GetOpenOrders(GetOpenOrdersRequest request)
		{
			if (request.FromDate > request.ToDate)
			{
				return Result<IEnumerable<OrderDto>>.Invalid<IEnumerable<OrderDto>>(ResultCodes.ORDER_INVALID_DATE_VALUES);
			}

			return Result<IEnumerable<OrderDto>>.Ok(
				await orderRepository.GetOpenOrders(
					from: request.FromDate,
					to: request.ToDate));
		}
	}
}
