namespace Shop.Contracts.Order.Requests
{
	public class GetOpenOrdersRequest
	{
		public DateTime FromDate { get; }

		public DateTime ToDate { get; }

		public GetOpenOrdersRequest(DateTime fromDate, DateTime toDate) 
		{
			FromDate = fromDate;
			ToDate = toDate;
		}
	}
}
