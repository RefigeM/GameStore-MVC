namespace GameStore.DAL.Models
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime? LastModifiedTime { get; set; }
		public DateTime? DeletedTime { get; set; }
	}
}
