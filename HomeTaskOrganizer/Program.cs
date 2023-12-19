using HomeTaskOrganizer.Components;
using HomeTaskOrganizer.Repositories;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");
// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddScoped<SQLPersonRepository>();
   
var app = builder.Build();
app.Services.Configure<RazorComponentsServiceOptions>(options =>
{
    options.AddInteractiveServerComponents();
});
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
