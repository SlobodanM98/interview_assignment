namespace Shop.Domain.Product
{
	using Shop.Domain.Common;
	using Shop.Domain.OrderItem;

	public sealed class Product : Entity
	{
		public Product()
		{
			State = EntityState.Unchanged;
		}

		public decimal Price { get; private set; }

		public string Name { get; private set; }

		public ICollection<OrderItem> OrderItems { get; private set; } = [];
	}
}
