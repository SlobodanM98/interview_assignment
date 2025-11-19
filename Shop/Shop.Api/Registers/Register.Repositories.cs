namespace Shop.Api.Registers
{
	using Shop.Contracts.Order.Repositories;
	using Shop.Contracts.Product.Repositories;
	using Shop.Storage.Order;
	using Shop.Storage.Product;

	public static partial class Register
	{
		public static IServiceCollection RegisterRepositories(this IServiceCollection services)
		{
			services.AddScoped<IOrderRepository, OrderRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();

			return services;
		}
	}
}
