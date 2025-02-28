var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute();//if we use this defaul it will take the dafault controller
app.UseStaticFiles();//becoz we add wwroot for that we need
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");// ? means optional

app.Run();


//void Foo(string firstName,string secondName,string location="Mumbai")
//{

//}
//Foo(lastName: "Hello Foo", firstName: "my firstName");
