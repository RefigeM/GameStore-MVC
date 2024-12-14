using GameStore.DAL.Models;

namespace GameStore.BL.Services.Abstractions
{
	public interface ITrendingGamesService
	{
		Task<List<TrendingGames>> GetTrendingGamesAsync();	
	}
}
