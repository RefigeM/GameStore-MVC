using GameStore.BL.Services.Abstractions;
using GameStore.BL.Services.Concretes;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ITrendingGamesService _serviceContext;
		public HomeController(ITrendingGamesService serviceContext)
		{
			_serviceContext = serviceContext;
		}
		public async Task<IActionResult> Index()
		{
			List<TrendingGames> trendingGames = await _serviceContext.GetTrendingGamesAsync();
			return View(trendingGames);
		}
	}
}
