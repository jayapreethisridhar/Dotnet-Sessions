using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
