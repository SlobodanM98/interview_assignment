namespace Shop.Api.Registers
{
	using Shop.Contracts.Order.Services;
	using Shop.Services.Order.Services;

	public static partial class Register
	{
		public static IServiceCollection RegisterServices(this IServiceCollection services)
		{
			services.AddScoped<IOrderService, OrderService>();

			return services;
		}
	}
}
