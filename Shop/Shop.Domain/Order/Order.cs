namespace Shop.Domain.Order
{
	using Shop.Domain.Common;
	using Shop.Domain.Customer;
	using Shop.Domain.Order.Enumerations;
	using Shop.Domain.OrderItem;

	public sealed class Order : Entity
	{
		public Order() 
		{
			State = EntityState.Unchanged;
		}

		public int CustomerId { get; private set; }

		public OrderStatus Status { get; private set; }

		public Customer Customer { get; private set; }

		public ICollection<OrderItem> OrderItems { get; private set; } = [];
	}
}
