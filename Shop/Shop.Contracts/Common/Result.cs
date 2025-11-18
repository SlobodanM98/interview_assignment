using System.Net;

namespace Shop.Contracts.Common
{
	public class Result
	{
		public bool IsFailure { get; }

		public bool IsSuccess => !IsFailure;

		public string? Message { get; }

		public ResultType ResultType { get; }

		protected Result(ResultType resultType, bool isFailure, string message)
		{
			if (isFailure)
			{
				if (string.IsNullOrWhiteSpace(message))
				{
					throw new ArgumentNullException(nameof(message), "There must be error message for failure.");
				}

				if (resultType == ResultType.Ok)
				{
					throw new ArgumentException("There should be error type for failure.", nameof(resultType));
				}
			}
			else
			{
				if (!string.IsNullOrWhiteSpace(message))
				{
					throw new ArgumentException("There should be no error message for success.", nameof(message));
				}

				if (resultType != ResultType.Ok)
				{
					throw new ArgumentException("There should be no error type for success.", nameof(resultType));
				}
			}

			Message = message;
			IsFailure = isFailure;
			ResultType = resultType;
		}

		private Result() : this(ResultType.Ok, isFailure: false, string.Empty) { }

		private Result(ResultType resultType, string message) : this(resultType, isFailure: true, message) { }

		public static Result Ok()
		{
			return new Result();
		}

		public static Result Failed(string message)
		{
			return new Result(ResultType.InternalError, message);
		}

		public static Result Invalid(string message)
		{
			return new Result(ResultType.Invalid, message);
		}

		public static Result NotFound(string message)
		{
			return new Result(ResultType.NotFound, message);
		}

		public HttpStatusCode HttpStatusCode => ResultType switch
		{
			ResultType.Ok => HttpStatusCode.OK,
			ResultType.NotFound => HttpStatusCode.NotFound,
			ResultType.Invalid => HttpStatusCode.NotAcceptable,
			_ => HttpStatusCode.InternalServerError,
		};
	}

	public class Result<T> : Result
	{
		public T Value { get; }

		private static T Empty => default(T);

		private Result(T value) : base(ResultType.Ok, isFailure: false, string.Empty)
		{
			Value = value;
		}

		private Result(ResultType resultType, bool isFailure, string message) : base(resultType, isFailure, message)
		{
			Value = Empty;
		}

		public static Result<T> Ok<T>(T value)
		{
			return new Result<T>(value);
		}

		public static Result<T> Failed<T>(string message)
		{
			return new Result<T>(ResultType.InternalError, isFailure: true, message);
		}

		public static Result<T> Invalid<T>(string message)
		{
			return new Result<T>(ResultType.Invalid, isFailure: true, message);
		}

		public static Result<T> NotFound<T>(string message)
		{
			return new Result<T>(ResultType.NotFound, isFailure: true, message);
		}
	}
}
