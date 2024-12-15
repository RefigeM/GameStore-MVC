using GameStore.BL.Services.Abstractions;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Areas.Admin.Controllers
{
	
		[Area("Admin")]
		public class ProductController : Controller
		{
			private readonly ITrendingGamesService _serviceContext;
			public ProductController(ITrendingGamesService serviceContext)
			{
				_serviceContext=serviceContext;
			}
			public async Task<ActionResult> Index() 
			{
			var games =await _serviceContext.GetTrendingGamesAsync();
			return View(games);
			}

		}

	}
