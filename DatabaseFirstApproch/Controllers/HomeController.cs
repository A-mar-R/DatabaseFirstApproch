using DatabaseFirstApproch.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DatabaseFirstApproch.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentsDbContext context;

        public HomeController(StudentsDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var data = context.Students.ToList();
            return View(data);
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
