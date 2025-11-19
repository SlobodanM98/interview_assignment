namespace Shop.Storage.Common
{
	public abstract class Entity
	{
		protected Entity() { }

		protected Entity(int id, Guid uid, DateTime createdOn, DateTime? deletedOn)
		{
			Id = id;
			Uid = uid;
			CreatedOn = createdOn;
			DeletedOn = deletedOn;
		}

		public int Id { get; protected set; }

		public Guid Uid { get; protected set; }

		public DateTime CreatedOn { get; protected set; }

		public DateTime? DeletedOn { get; protected set; }
	}
}
