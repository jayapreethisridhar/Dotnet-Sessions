using Microsoft.AspNetCore.Mvc;

namespace Controllers&Actions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("<h1>Hello HTML page</h1>","text/html");//our content will display content means string content
        }
        public IActionResult Veggie()
        {
            return File("/Images/pizza.jpg", "Image/jpg");
        }
        public IActionResult About(string id = "101")
        {
            return Content($"<h1>Id you passed is {id},getting details</h1>");
        }
        public IActionResult Greet(string userName = "Preethi")//query string multiple values are passed into query i.e. last & first name
        {
            return Content($"<h1> Welcome back {userName} !!!</h1>", "text/html");
        }
        public IActionResult Payment()
        {
            return Redirect("https://rrd.com");
        }
        public IActionResult Random()
        {
            //double? commission = null;//getting commission

            var random = new Random();
            var result = random.Next(1, 10);
            if (result > 5)
            {
                return RedirectToAction("About");
            }
            return RedirectToAction("Greet");
        }
    }
}

