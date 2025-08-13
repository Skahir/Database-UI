using BlazorLearningApp.Components;
using BlazorLearningApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<BlazorLearningAppContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BlazorLearningAppContext") ?? throw new InvalidOperationException("Connection string 'BlazorLearningAppContext' not found.")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddQuickGridEntityFrameworkAdapter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
