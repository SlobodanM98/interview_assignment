namespace Shop.Storage.Order
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class OrderMapping : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.ToTable("Order", "Shop");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").HasColumnType("smalldatetime").IsRequired();
			builder.Property(x => x.DeletedOn).HasColumnName("DeletedOn").HasColumnType("smalldatetime");
			builder.Property(x => x.CustomerId).HasColumnName("CustomerFk").HasColumnType("int").IsRequired();
			builder.Property(x => x.Status).HasColumnName("Status").HasColumnType("nvarchar(50)").IsRequired();

			builder.HasMany(x => x.OrderItems).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);

			builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
		}
	}
}
