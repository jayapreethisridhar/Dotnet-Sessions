using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ServiceDepencyInjection.Services;
using System;
using System.Threading.Tasks;

namespace ServiceDepencyInjection.Middlewares
{
    public class RddLogAndEmailingMiddleware
    {
        private readonly RequestDelegate _next;

        public RddLogAndEmailingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext, IRRdEmailService emailService)
        {
            Console.WriteLine("Pre Login Check");
            await emailService.SendEmailAsync("admin@rrd", "from middleware", "Middle email called succesfully");
            await _next(httpContext);
            Console.WriteLine("Post Login Check");
        }
    }
    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class RddLogAndEmailingMiddleExtensions
    //{
    //    public static IApplicationBuilder UseRddLogAndEmailingMiddle(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<RddLogAndEmailingMiddle>();
    //    }
    //}
}
