using CarApplication_Mudblazor.Services;
using Microsoft.EntityFrameworkCore;
using CarApplication_Mudblazor.Components;
using MudBlazor.Services;
using CarApplication_Mudblazor.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();

builder.Services.AddMudServices();
builder.Services.AddDbContext<CarApplication_Mudblazor.Data.ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarService, CarService>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) 
                    .AllowCredentials());

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();



app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
