using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.DAL.Contexts
{
	public class GameStoreDbContext : DbContext
	{
		public DbSet<TrendingGames> TrendingGames { get; set; }
		public GameStoreDbContext(DbContextOptions<GameStoreDbContext> opt) : base(opt)
		{
			
		}


	}
}
