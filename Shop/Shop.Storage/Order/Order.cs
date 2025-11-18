namespace Shop.Storage.Order
{
	using Shop.Storage.Common;
	using Shop.Storage.Customer;
	using Shop.Storage.OrderItem;

	public class Order : Entity
	{
		public Order() { }

		public int CustomerId { get; private set; }

		public int Status { get; private set; }

		public Customer Customer { get; private set; }

		public ICollection<OrderItem> OrderItems { get; private set; } = [];
	}
}
