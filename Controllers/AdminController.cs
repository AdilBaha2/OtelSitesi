using Microsoft.AspNetCore.Mvc;
using OtelSitesi.Data;
using OtelSitesi.Models;

namespace OtelSitesi.Controllers
{
	public class AdminController : Controller
	{
		
		private const string AdminUsername = "admin";
		private const string AdminPassword = "123456";

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			if (username == AdminUsername && password == AdminPassword)
			{
				
				return RedirectToAction("Dashboard");
			}

			ViewData["Error"] = "Kullanıcı adı veya şifre yanlış!";
			return View();
		}

		public IActionResult Dashboard()
		{
			return View();
		}
	}
}
