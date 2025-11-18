namespace Shop.Domain.OrderItem
{
	using Shop.Domain.Common;
	using Shop.Domain.Order;
	using Shop.Domain.Product;

	public sealed class OrderItem : Entity
	{
		public OrderItem()
		{
			State = EntityState.Unchanged;
		}

		public int ProductId { get; private set; }

		public int OrderId { get; private set; }

		public decimal Price { get; private set; }

		public int Quantity { get; private set; }

		public Product Product { get; private set; }

		public Order Order { get; private set; }
	}
}
