namespace Shop.Contracts.Order.Response
{
	public class OrderDto
	{
		public IEnumerable<OrderItemDto> Items { get; set; } = [];

		public class OrderItemDto
		{
			public string ProductName { get; set; }

			public decimal ProductPrice { get; set; }

			public int Quantity { get; set; }
		}
	}
}
