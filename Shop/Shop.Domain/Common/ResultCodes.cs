using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Common
{
	public static class ResultCodes
	{
		#region Order

		public const string ORDER_INVALID_DATE_VALUES = "ORDER_INVALID_DATE_VALUES";

		#endregion

		#region Product

		public const string PRODUCT_INVALID_FILTER_VALUE = "PRODUCT_INVALID_FILTER_VALUE";

		#endregion
	}
}
