namespace Shop.Client
{
	using Microsoft.Extensions.Options;
	using Shop.Client.Configurations;
	using Shop.Client.Services;
	using Shop.Client.Services.Interfaces;

	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.Configure<ApiSettings>(
				builder.Configuration.GetSection("ApiSettings"));

			builder.Services.AddHttpClient<IProductService, ProductService>((sp, client) =>
			{
				ApiSettings settings = sp.GetRequiredService<IOptions<ApiSettings>>().Value;
				client.BaseAddress = new Uri(settings.BaseUrl);
			});

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Product}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
