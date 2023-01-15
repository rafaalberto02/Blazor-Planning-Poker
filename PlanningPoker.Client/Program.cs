using PlanningPoker.Client.DI;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseStaticWebAssets();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.AddServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();