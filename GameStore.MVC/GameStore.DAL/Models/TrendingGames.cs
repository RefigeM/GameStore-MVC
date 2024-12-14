namespace GameStore.DAL.Models
{
	public class TrendingGames :BaseEntity
	{
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public int Price { get; set; }
		public int Discount { get; set; }
	}
}
