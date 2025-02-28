using ServiceDepencyInjection.Middlewares;
using ServiceDepencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllerWithViews();
builder.Services.AddTransient<IRRdEmailService, TwilioEmailService>();

var app = builder.Build(); //abover build register sevices

//app.MapGet("/", () => "Hello World!");

app.UseMiddleware<RddLogAndEmailingMiddleware>();
app.MapDefaultControllerRoute();

app.Run(); //above run register middleware
