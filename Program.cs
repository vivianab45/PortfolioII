var builder = WebApplication.CreateBuilder(args);

//add services
builder.Services.AddControllersWithViews();

var app = builder.Build();

//add methods
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//add how we want things to be mapped
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
