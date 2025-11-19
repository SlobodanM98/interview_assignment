namespace Shop.Contracts.Product.Requests
{
	using Shop.Contracts.Product.Enumerations;

	public class GetTopTenProductsRequest
	{
		public SortBy? SortBy { get; set; }
	}
}
