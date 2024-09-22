var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Defining the default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomDefined}/{action=Index}/{id?}"
);

app.Run();
  