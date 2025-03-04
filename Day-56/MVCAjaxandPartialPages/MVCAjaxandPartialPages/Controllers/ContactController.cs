using Microsoft.AspNetCore.Mvc;

namespace MasterApplication.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetTimeStamp()
        {

            return View("_TimeStamp", new TimeStampDto { Title = "Contacts us Timestampe" });

        }
    }
}
