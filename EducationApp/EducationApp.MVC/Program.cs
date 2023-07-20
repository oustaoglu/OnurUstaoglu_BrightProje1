using AspNetCoreHero.ToastNotification;
using EducationApp.Business.Abstract;
using EducationApp.Business.Concrete;
using EducationApp.Data.Abstract;
using EducationApp.Data.Concrete.EFCore.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IInstructorService, InstructorManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>();
builder.Services.AddScoped<IInstructorRepository, EfCoreInstructorRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 5;
    config.IsDismissable = true;
    config.Position = NotyfPosition.BottomRight;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "productscategory",
    pattern: "kategoriler/{categoryurl?}",
    defaults: new { controller = "EducationApp", action = "ProductList" }
    );

app.MapControllerRoute(
    name: "productsinstructor",
    pattern: "egitmenler/{instructorurl?}",
    defaults: new { controller = "EducationApp", action = "InstructorList" }
    );

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "admin/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
