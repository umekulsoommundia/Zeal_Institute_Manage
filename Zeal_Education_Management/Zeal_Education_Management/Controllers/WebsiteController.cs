using Microsoft.AspNetCore.Mvc;

namespace Zeal_Education_Management.Controllers
{
	public class WebsiteController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
