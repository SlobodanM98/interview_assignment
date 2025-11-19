namespace Shop.Contracts.Product.Responses
{
	public class ProductDto
	{
		public string Name { get; set; }

		public decimal CurrentPrice { get; set; }

		public decimal TotalDollarAmountSold { get; set; }

		public int VolumeSold { get; set; }

		public DateTime CreatedOn { get; set; }
	}
}
