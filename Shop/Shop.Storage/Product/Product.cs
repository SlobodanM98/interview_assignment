namespace Shop.Storage.Product
{
	using Shop.Storage.Common;
	using Shop.Storage.OrderItem;

	public sealed class Product : Entity
	{
		public Product() { }

		public decimal Price { get; private set; }

		public string Name { get; private set; }

		public ICollection<OrderItem> OrderItems { get; private set; } = [];
	}
}
