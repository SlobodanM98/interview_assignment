namespace Shop.Storage.OrderItem
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
	{
		public void Configure(EntityTypeBuilder<OrderItem> builder)
		{
			builder.ToTable("OrderItem", "Shop");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").HasColumnType("smalldatetime").IsRequired();
			builder.Property(x => x.DeletedOn).HasColumnName("DeletedOn").HasColumnType("smalldatetime");
			builder.Property(x => x.ProductId).HasColumnName("ProductFk").HasColumnType("int").IsRequired();
			builder.Property(x => x.OrderId).HasColumnName("OrderFk").HasColumnType("int").IsRequired();
			builder.Property(x => x.Price).HasColumnName("Price").HasColumnType("decimal(10,2)").IsRequired();
			builder.Property(x => x.Quantity).HasColumnName("Quantity").HasColumnType("int").IsRequired();

			builder.HasOne(x => x.Product).WithMany(x => x.OrderItems).HasForeignKey(x => x.ProductId);
			builder.HasOne(x => x.Order).WithMany(x => x.OrderItems).HasForeignKey(x => x.OrderId);
		}
	}
}
