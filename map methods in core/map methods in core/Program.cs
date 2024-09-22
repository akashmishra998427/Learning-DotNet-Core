var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // deligate returning a string

//app.Map("/Home", () => "My name is akash"); // map all the request no matter wather it is get post delete update

//app.MapGet("/Home", () => "this is the get request"); // this method is only work with get method

//app.MapPut("/Home", () => "this is the put method"); // this will work only for the put method

// app.MapPost("/Home", () => "this is the post method"); // this will work only for the post method


//app.MapDelete(("/Home", () => "this is the delete request"); //this will only work for delete request


//============ defining the routing ==================

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is the home page ..Get");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is the home page..Post");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is the home page ..Delete");
    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is the home page..Put");
    });
});

app.Run();
