namespace Shop.Storage.Customer
{
	using Shop.Storage.Common;
	using Shop.Storage.Order;

	public class Customer : Entity
	{
		public Customer() { }

		public Customer(
			int id,
			Guid uid,
			DateTime createdOn,
			DateTime? deletedOn,
			string firstName,
			string lastName,
			string email) : base(id, uid, createdOn, deletedOn)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
		}

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public string Email { get; private set; }

		public ICollection<Order> Orders { get; private set; } = [];
	}
}
