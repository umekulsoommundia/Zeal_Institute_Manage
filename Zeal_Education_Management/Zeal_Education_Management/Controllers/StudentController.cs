using Microsoft.AspNetCore.Mvc;
using Zeal_Education_Management.Models;

namespace Zeal_Education_Management.Controllers
{
	public class StudentController : Controller
	{
	

		public IActionResult Index()
		{
			return View();
		}
	}
}
