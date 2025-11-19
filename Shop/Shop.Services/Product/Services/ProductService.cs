namespace Shop.Services.Product.Services
{
	using Shop.Contracts.Common;
	using Shop.Contracts.Product.Enumerations;
	using Shop.Contracts.Product.Repositories;
	using Shop.Contracts.Product.Requests;
	using Shop.Contracts.Product.Responses;
	using Shop.Contracts.Product.Services;
	using Shop.Domain.Common;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public class ProductService(IProductRepository productRepository) : IProductService
	{
		public async Task<Result<IEnumerable<ProductDto>>> GetTopTenProducts(GetTopTenProductsRequest request)
		{
			if (request.SortBy.HasValue && !Enum.IsDefined(typeof(SortBy), request.SortBy))
			{
				return Result<IEnumerable<ProductDto>>.Invalid<IEnumerable<ProductDto>>(ResultCodes.PRODUCT_INVALID_FILTER_VALUE);
			}

			return Result<IEnumerable<ProductDto>>.Ok(
				await productRepository.GetTopTenProducts(
					sortBy: request?.SortBy));
		}
	}
}
