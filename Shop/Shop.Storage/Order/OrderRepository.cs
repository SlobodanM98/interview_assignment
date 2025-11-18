namespace Shop.Storage.Order
{
	using Microsoft.EntityFrameworkCore;
	using Shop.Contracts.Order.Repositories;
	using Shop.Contracts.Order.Response;
	using Shop.Domain.Order.Enumerations;
	using Shop.Storage.Context;
	using System;
	using System.Threading.Tasks;

	public class OrderRepository(ShopDbContext dbContext) : IOrderRepository
	{
		public async Task<IEnumerable<OrderDto>> GetOpenOrders(DateTime from, DateTime to)
		{
			return await dbContext.Set<Order>()
				.Where(x => x.DeletedOn == null
								&& x.CreatedOn >= from
									&& x.CreatedOn <= to
										&& x.Status == ((int)OrderStatus.Open))
				.Include(x => x.OrderItems)
					.ThenInclude(x => x.Product)
				.Select(x => new OrderDto()
				{
					Items = x.OrderItems.Select(y => new OrderDto.OrderItemDto()
					{
						ProductName = y.Product.Name,
						ProductPrice = y.Product.Price,
						Quantity = y.Quantity
					})
				}).ToArrayAsync();
		}
	}
}
