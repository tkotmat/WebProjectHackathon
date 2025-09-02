using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.BusinessLogic.Service;
using WebProjectHackathon.DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite("Data Source=DataAccess/Root/Database/HackathonDatabase.db"));

builder.Services.AddScoped<IProfessionsRepository, ProfessionsRepository>();
builder.Services.AddScoped<IProfessionsService, ProfessionsService>();


builder.Services.AddControllersWithViews();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
