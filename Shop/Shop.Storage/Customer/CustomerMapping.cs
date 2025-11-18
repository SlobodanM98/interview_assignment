namespace Shop.Storage.Customer
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class CustomerMapping : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.ToTable("Customer", "Shop");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").HasColumnType("smalldatetime").IsRequired();
			builder.Property(x => x.DeletedOn).HasColumnName("DeletedOn").HasColumnType("smalldatetime");
			builder.Property(x => x.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.LastName).HasColumnName("LastName").HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar(255)").IsRequired();

			builder.HasMany(x => x.Orders).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
		}
	}
}
