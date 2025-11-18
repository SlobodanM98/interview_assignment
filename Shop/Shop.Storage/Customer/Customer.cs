namespace Shop.Storage.Customer
{
	using Shop.Storage.Common;
	using Shop.Storage.Order;

	public class Customer : Entity
	{
		public Customer() { }

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public string Email { get; private set; }

		public ICollection<Order> Orders { get; private set; } = [];
	}
}
