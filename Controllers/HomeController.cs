using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPhoneBook.Models;

namespace WebPhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonContext db;

        public HomeController(PersonContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Persons.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
