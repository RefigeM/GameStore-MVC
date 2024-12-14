using GameStore.BL.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Controllers
{
	public class ProductDetailsController : Controller
	{
		private readonly ITrendingGamesService _serviceContext;

		public ProductDetailsController(ITrendingGamesService serviceContext)
		{
			_serviceContext = serviceContext;
		}

		public async Task<IActionResult> Index(int id)
		{
			var games = await _serviceContext.GetTrendingGamesAsync();
			var game =  games.FirstOrDefault(x => x.Id == id);

			if (game == null) 
			{
			return NotFound();
			}

			return View(game);
		}
	}
}
