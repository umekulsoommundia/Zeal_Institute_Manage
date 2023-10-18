using Microsoft.AspNetCore.Mvc;

namespace Zeal_Education_Management.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
