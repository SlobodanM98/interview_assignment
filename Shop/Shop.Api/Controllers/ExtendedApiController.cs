namespace Shop.Api.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Shop.Contracts.Common;

	[ApiController]
	public class ExtendedApiController : ControllerBase
	{
		protected IActionResult OkOrError<T>(Result<T> result)
		{
			IActionResult? errorResponse = GetErrorResponse(result);

			if (errorResponse != null)
			{
				return errorResponse;
			}

			return Ok(result.Value);
		}

		protected IActionResult OkOrError(Result result)
		{
			IActionResult? errorResponse = GetErrorResponse(result);

			if (errorResponse != null)
			{
				return errorResponse;
			}

			return Ok();
		}

		private static IActionResult? GetErrorResponse(Result result)
		{
			if (result.IsFailure)
			{
				ObjectResult errorResponse = new(result.Message)
				{
					StatusCode = (int)result.GetHttpStatusCode()
				};

				return errorResponse;
			}

			return null;
		}
	}
}
