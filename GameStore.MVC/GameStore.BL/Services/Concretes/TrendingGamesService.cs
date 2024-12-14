using GameStore.BL.Services.Abstractions;
using GameStore.DAL.Contexts;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BL.Services.Concretes
{
	public class TrendingGamesService : ITrendingGamesService
	{
		private readonly GameStoreDbContext _context;

		public TrendingGamesService(GameStoreDbContext context)
		{
			_context = context;
		}

		public async Task<List<TrendingGames>> GetTrendingGamesAsync()
		{
			List<TrendingGames> trendingGames = await _context.TrendingGames.ToListAsync();
			return trendingGames;
		}

		
	}
}
