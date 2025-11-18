namespace Shop.Storage.Context
{
	using Microsoft.EntityFrameworkCore;
	using Shop.Storage.Customer;
	using Shop.Storage.Order;
	using Shop.Storage.OrderItem;
	using Shop.Storage.Product;

	public class ShopDbContext : DbContext
	{
		public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

		public DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new CustomerMapping());
			modelBuilder.ApplyConfiguration(new ProdcutMapping());
			modelBuilder.ApplyConfiguration(new OrderMapping());
			modelBuilder.ApplyConfiguration(new OrderItemMapping());
		}
	}
}
