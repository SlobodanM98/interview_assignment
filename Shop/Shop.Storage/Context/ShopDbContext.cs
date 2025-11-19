namespace Shop.Storage.Context
{
	using Microsoft.EntityFrameworkCore;
	using Shop.Domain.Order.Enumerations;
	using Shop.Storage.Customer;
	using Shop.Storage.Order;
	using Shop.Storage.OrderItem;
	using Shop.Storage.Product;

	public class ShopDbContext : DbContext
	{
		public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new CustomerMapping());
			modelBuilder.ApplyConfiguration(new ProdcutMapping());
			modelBuilder.ApplyConfiguration(new OrderMapping());
			modelBuilder.ApplyConfiguration(new OrderItemMapping());

			SeedData(modelBuilder);
		}

		private void SeedData(ModelBuilder modelBuilder)
		{
			int Customer1Id = 1;
			int Customer2Id = 2;
			int Product1Id = 1;
			int Product2Id = 2;
			int Product3Id = 3;
			int Product4Id = 4;
			int Product5Id = 5;
			int Product6Id = 6;
			int Product7Id = 7;
			int Product8Id = 8;
			int Product9Id = 9;
			int Product10Id = 10;
			int Product11Id = 11;
			int Product12Id = 12;
			int Order1Id = 1;
			int Order2Id = 2;
			int Order3Id = 3;
			int Order4Id = 4;
			int Order5Id = 5;
			int Order6Id = 6;
			int Order7Id = 7;

			modelBuilder.Entity<Customer>().HasData(
				new Customer(
					id: Customer1Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 10, 5),
					deletedOn: null,
					firstName: "Nikola",
					lastName: "Nikolic",
					email: "nikola@gmail.com"),
				new Customer(
					id: Customer2Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 8, 12),
					deletedOn: null,
					firstName: "Stefan",
					lastName: "Stefanovic",
					email: "stefan@gmail.com"));

			modelBuilder.Entity<Product>().HasData(
				new Product(
					id: Product1Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 499.99m,
					name: "Knjiga"),
				new Product(
					id: Product2Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 1499.99m,
					name: "Lampa"),
				new Product(
					id: Product3Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 2999.99m,
					name: "Slusalice"),
				new Product(
					id: Product4Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 31049.99m,
					name: "Telefon"),
				new Product(
					id: Product5Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 9999.99m,
					name: "Patike"),
				new Product(
					id: Product6Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 4499.99m,
					name: "Pantalone"),
				new Product(
					id: Product7Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 1199.99m,
					name: "Majica"),
				new Product(
					id: Product8Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 299.99m,
					name: "Tanjir"),
				new Product(
					id: Product9Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 8999.99m,
					name: "Jakna"),
				new Product(
					id: Product10Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 11999.99m,
					name: "Stolica"),
				new Product(
					id: Product11Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 54999.99m,
					name: "Televizor"),
				new Product(
					id: Product12Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 1, 1),
					deletedOn: null,
					price: 39999.99m,
					name: "Krevet"));

			modelBuilder.Entity<Order>().HasData(
				new Order(
					id: Order1Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 5, 11),
					deletedOn: null,
					customerId: Customer1Id,
					status: (int)OrderStatus.Completed),
				new Order(
					id: Order2Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 10, 26),
					deletedOn: null,
					customerId: Customer1Id,
					status: (int)OrderStatus.Open),
				new Order(
					id: Order3Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 11),
					deletedOn: null,
					customerId: Customer2Id,
					status: (int)OrderStatus.Open),
				new Order(
					id: Order4Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 10),
					deletedOn: null,
					customerId: Customer2Id,
					status: (int)OrderStatus.Canceled),
				new Order(
					id: Order5Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: new DateTime(2025, 11, 13),
					customerId: Customer2Id,
					status: (int)OrderStatus.Open),
				new Order(
					id: Order6Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: null,
					customerId: Customer1Id,
					status: (int)OrderStatus.Open),
				new Order(
					id: Order7Id,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 15),
					deletedOn: null,
					customerId: Customer2Id,
					status: (int)OrderStatus.Completed));

			modelBuilder.Entity<OrderItem>().HasData(
				new OrderItem(
					id: 1,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 5, 11),
					deletedOn: null,
					productId: Product1Id,
					orderId: Order1Id,
					price: 499.99m,
					quantity: 2),
				new OrderItem(
					id: 2,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 10, 26),
					deletedOn: null,
					productId: Product2Id,
					orderId: Order2Id,
					price: 999.99m,
					quantity: 1),
				new OrderItem(
					id: 3,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 10, 26),
					deletedOn: null,
					productId: Product3Id,
					orderId: Order2Id,
					price: 2999.99m,
					quantity: 1),
				new OrderItem(
					id: 4,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 11),
					deletedOn: null,
					productId: Product1Id,
					orderId: Order3Id,
					price: 399.99m,
					quantity: 3),
				new OrderItem(
					id: 5,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 11),
					deletedOn: null,
					productId: Product2Id,
					orderId: Order3Id,
					price: 1499.99m,
					quantity: 1),
				new OrderItem(
					id: 6,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 11),
					deletedOn: null,
					productId: Product4Id,
					orderId: Order3Id,
					price: 31049.99m,
					quantity: 1),
				new OrderItem(
					id: 7,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 10),
					deletedOn: null,
					productId: Product4Id,
					orderId: Order4Id,
					price: 34999.99m,
					quantity: 1),
				new OrderItem(
					id: 8,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: null,
					productId: Product4Id,
					orderId: Order5Id,
					price: 34999.99m,
					quantity: 2),
				new OrderItem(
					id: 9,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: null,
					productId: Product3Id,
					orderId: Order6Id,
					price: 3499.99m,
					quantity: 1),
				new OrderItem(
					id: 10,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: null,
					productId: Product5Id,
					orderId: Order6Id,
					price: 9999.99m,
					quantity: 1),
				new OrderItem(
					id: 11,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: null,
					productId: Product6Id,
					orderId: Order6Id,
					price: 3499.99m,
					quantity: 2),
				new OrderItem(
					id: 12,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 12),
					deletedOn: null,
					productId: Product7Id,
					orderId: Order6Id,
					price: 1199.99m,
					quantity: 4),
				new OrderItem(
					id: 13,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 15),
					deletedOn: null,
					productId: Product8Id,
					orderId: Order7Id,
					price: 199.99m,
					quantity: 4),
				new OrderItem(
					id: 14,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 15),
					deletedOn: null,
					productId: Product9Id,
					orderId: Order7Id,
					price: 8999.99m,
					quantity: 1),
				new OrderItem(
					id: 15,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 15),
					deletedOn: null,
					productId: Product10Id,
					orderId: Order7Id,
					price: 12999.99m,
					quantity: 1),
				new OrderItem(
					id: 16,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 15),
					deletedOn: null,
					productId: Product11Id,
					orderId: Order7Id,
					price: 49999.99m,
					quantity: 1),
				new OrderItem(
					id: 17,
					uid: Guid.NewGuid(),
					createdOn: new DateTime(2025, 11, 15),
					deletedOn: null,
					productId: Product12Id,
					orderId: Order7Id,
					price: 39999.99m,
					quantity: 1));
		}
	}
}
