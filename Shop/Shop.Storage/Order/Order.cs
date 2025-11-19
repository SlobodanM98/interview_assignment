namespace Shop.Storage.Order
{
	using Shop.Storage.Common;
	using Shop.Storage.Customer;
	using Shop.Storage.OrderItem;

	public class Order : Entity
	{
		public Order() { }

		public Order(
			int id,
			Guid uid,
			DateTime createdOn,
			DateTime? deletedOn,
			int customerId,
			int status) : base(id, uid, createdOn, deletedOn)
		{
			CustomerId = customerId;
			Status = status;
		}

		public int CustomerId { get; private set; }

		public int Status { get; private set; }

		public Customer Customer { get; private set; }

		public ICollection<OrderItem> OrderItems { get; private set; } = [];
	}
}
