namespace Shop.Client.Models.Requests
{
	using Shop.Client.Models.Enumerations;

	public class GetTopTenProductsRequest
	{
		public SortBy? SortBy { get; set; }
	}
}
