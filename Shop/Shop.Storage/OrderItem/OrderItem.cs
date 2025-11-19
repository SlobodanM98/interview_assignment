namespace Shop.Storage.OrderItem
{
	using Shop.Storage.Common;
	using Shop.Storage.Order;
	using Shop.Storage.Product;

	public class OrderItem : Entity
	{
		public OrderItem() { }

		public OrderItem(
			int id,
			Guid uid,
			DateTime createdOn,
			DateTime? deletedOn,
			int productId,
			int orderId,
			decimal price,
			int quantity) : base(id, uid, createdOn, deletedOn)
		{
			ProductId = productId;
			OrderId = orderId;
			Price = price;
			Quantity = quantity;
		}

		public int ProductId { get; private set; }

		public int OrderId { get; private set; }

		public decimal Price { get; private set; }

		public int Quantity { get; private set; }

		public Product Product { get; private set; }

		public Order Order { get; private set; }
	}
}
