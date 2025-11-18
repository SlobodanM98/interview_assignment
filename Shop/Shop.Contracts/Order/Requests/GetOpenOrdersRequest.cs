namespace Shop.Contracts.Order.Requests
{
	public class GetOpenOrdersRequest
	{
		public DateTime FromDate { get; set; }

		public DateTime ToDate { get; set; }
	}
}
