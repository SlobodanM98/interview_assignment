namespace Shop.Storage.Product
{
	using Shop.Storage.Common;
	using Shop.Storage.OrderItem;

	public sealed class Product : Entity
	{
		public Product() { }

		public Product(
			int id,
			Guid uid,
			DateTime createdOn,
			DateTime? deletedOn,
			decimal price,
			string name) : base(id, uid, createdOn, deletedOn)
		{
			Price = price;
			Name = name;
		}

		public decimal Price { get; private set; }

		public string Name { get; private set; }

		public ICollection<OrderItem> OrderItems { get; private set; } = [];
	}
}
