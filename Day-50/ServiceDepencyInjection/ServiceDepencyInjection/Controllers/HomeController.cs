using Microsoft.AspNetCore.Mvc;

namespace ServiceDepencyInjection.Controllers
{
    public class HomeController:Controller
    {
        public HomeController() 
        {
            Console.WriteLine("controller created");
        }
        public string Index()
        {
            return "Hello rom index action or home controller";
        }
        public string SayHello()
        {
            return "Hello";
        }
    }
}
