namespace Shop.Contracts.Order.Repositories
{
	using Shop.Contracts.Order.Response;

	public interface IOrderRepository
	{
		Task<IEnumerable<OrderDto>> GetOpenOrders(DateTime from, DateTime to);
	}
}
