namespace Shop.Api.Registers
{
	using Shop.Contracts.Order.Repositories;
	using Shop.Storage.Order;

	public static partial class Register
	{
		public static IServiceCollection RegisterRepositories(this IServiceCollection services)
		{
			services.AddScoped<IOrderRepository, OrderRepository>();

			return services;
		}
	}
}
