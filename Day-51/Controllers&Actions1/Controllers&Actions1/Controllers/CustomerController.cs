using Microsoft.AspNetCore.Mvc;
using Controllers_Actions1.Models;

namespace Controllers_Actions1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Display()
        {

            var c1 = new Customer
            {
                City = "Chennai",
                Id = 1,
                Name = "Venkat",

            };
            return View(c1);

        }
    }
}
