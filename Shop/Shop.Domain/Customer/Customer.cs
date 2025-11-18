namespace Shop.Domain.Customer
{
	using Shop.Domain.Common;
	using Shop.Domain.Order;

	public sealed class Customer : Entity
	{
		public Customer() 
		{
			State = EntityState.Unchanged;
		}

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public string Email { get; private set; }

		public ICollection<Order> Orders { get; private set; } = [];
	}
}
