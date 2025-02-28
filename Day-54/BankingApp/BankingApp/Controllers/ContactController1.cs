using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    public class ContactController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
