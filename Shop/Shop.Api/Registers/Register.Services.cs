namespace Shop.Api.Registers
{
	using Shop.Contracts.Order.Services;
	using Shop.Contracts.Product.Services;
	using Shop.Services.Order.Services;
	using Shop.Services.Product.Services;

	public static partial class Register
	{
		public static IServiceCollection RegisterServices(this IServiceCollection services)
		{
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IProductService, ProductService>();

			return services;
		}
	}
}
