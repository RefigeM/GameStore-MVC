using GameStore.BL.Services.Abstractions;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DashboardController : Controller
	{
		private readonly ITrendingGamesService _serviceContext;

		public DashboardController(ITrendingGamesService serviceContex)
		{
			_serviceContext = serviceContex;
		}

		public async Task<IActionResult> Index()
		{
			List<TrendingGames> trendingGames = await _serviceContext.GetTrendingGamesAsync();
			return View(trendingGames);
		}
	}
}
