namespace Shop.Api.Settings
{
	using Shop.Contracts.Settings;

	internal class AppSettings(IConfiguration configuration) : IAppSettings
	{
		public string SqlConnectionString => configuration.GetValue<string>("ConnectionString");
	}
}
