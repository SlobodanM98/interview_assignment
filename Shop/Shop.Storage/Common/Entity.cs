namespace Shop.Storage.Common
{
	public abstract class Entity
	{
		protected Entity() { }

		public int Id { get; protected set; }

		public Guid Uid { get; protected set; }

		public DateTime CreatedOn { get; protected set; }

		public DateTime? DeletedOn { get; protected set; }
	}
}
