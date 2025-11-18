namespace Shop.Api.Registers
{
	using Microsoft.EntityFrameworkCore;
	using Shop.Api.Settings;
	using Shop.Contracts.Settings;
	using Shop.Storage.Context;

	public static partial class Register
	{
		public static IServiceCollection RegisterContext(
			this IServiceCollection services,
			IConfiguration configuration)
		{
			IAppSettings settings = new AppSettings(configuration);

			services.AddDbContext<ShopDbContext>(options =>
			{
				options.UseSqlServer(settings.SqlConnectionString);
			});

			return services;
		}
	}
}
