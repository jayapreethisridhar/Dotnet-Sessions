using Microsoft.AspNetCore.Mvc;
using Controllers&Actions.Model;

namespace Controllers&Actions.Controllers
    {
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display()
        {
            var c1 = new Customer1 { 
                Id = 1,
                Name = "Preethi",
                City = "Chennai"
            };
            return View(c1);
        }
    }
}

