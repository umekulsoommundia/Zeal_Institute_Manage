using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zeal_Education_Management.Models;

namespace Zeal_Education_Management.Controllers
{
	public class CourseController : Controller
	{
		private readonly ZealDBContext _dbContext;
		public CourseController(ZealDBContext dBContext)
		{
			_dbContext = dBContext;
		}

		public IActionResult Index()
		{
			var courses = _dbContext.Courses.ToList();
			return View(courses);
		}

		public IActionResult CreateCourse()
		{
			return View();
		}




		[HttpPost]
		public IActionResult CreateCourse(CourseModel course)
		{
			if (ModelState.IsValid)
			{
				_dbContext.Courses.Add(course);
				_dbContext.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(course);
		}
	}
}
