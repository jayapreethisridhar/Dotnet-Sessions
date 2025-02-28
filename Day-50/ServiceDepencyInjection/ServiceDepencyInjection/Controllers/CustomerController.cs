using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using ServiceDepencyInjection.Services;

namespace ServiceDepencyInjection.Controllers
{
    public class CustomerController:Controller
    {
        private IRRdEmailService _rdrEmailService;
        public CustomerController(IRRdEmailService emailService)
        {
            _rdrEmailService = emailService;
        }
        public string Index()
        {
            _rdrEmailService.SendEmailAsync("admin@rrd","controller","customer registration controller");
            return "<h1>Hello I am index action of home controller</h1>";
        }
    }
}
