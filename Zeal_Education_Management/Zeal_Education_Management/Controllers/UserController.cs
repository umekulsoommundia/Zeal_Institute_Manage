using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zeal_Education_Management.Models;

namespace Zeal_Education_Management.Controllers
{
	public class UserController : Controller
	{
		private readonly ZealDBContext _dbContext;
		public UserController(ZealDBContext dBContext)
		{
			_dbContext = dBContext;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Signup()
		{
			return View();
		}


			[HttpPost]
			public async Task<IActionResult> SignUp(UserModel model)
			{
				if (ModelState.IsValid)
				{
					var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
					if (existingUser != null)
					{


					TempData["AlertMessage"] = "Email already in use";
					return View(model);
					}

				
					_dbContext.Users.Add(model);
					await _dbContext.SaveChangesAsync();

					return RedirectToAction("Index", "Home");
				}
			TempData["AlertMessage"] = "An error occurred while processing your request";

			return View(model);
			}

		public IActionResult Signin()
		{
			return View();
		}



		[HttpPost]
		public async Task<IActionResult> Login(UserModel model)
		{
			Console.WriteLine("Login action called");

			if (ModelState.IsValid)
			{
				var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
				if (user == null || user.Password != model.Password) // TODO: Compare hashed passwords, not plain text
				{
					TempData["AlertMessage"] = "Invalid login attempt.";
					return RedirectToAction("Signin", "User");
				}

				// Store the user's ID in the session
				HttpContext.Session.SetInt32("UserId", user.Id);

				// Write the user's ID to the console
				Console.WriteLine($"User ID stored in session: {user.Id}");

				// Redirect based on user type
				if (user.UserType == UserType.Student)
				{
					return RedirectToAction("Index", "Student");
				}
				else if (user.UserType == UserType.Instructor)
				{
					return RedirectToAction("Index", "Instructor");
				}
			}

			Console.WriteLine("Login action completed");

			// If we got this far, something failed
			TempData["AlertMessage"] = "An error occurred while processing your request";
			return RedirectToAction("Signin", "User");
		}

	}




}
