using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using eCapitalAssignment.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRazorPages()
    .AddRazorPagesOptions(options =>
    {
        options.Conventions
            .AddPageRoute("/upsert", "/upsert/{id:int}")
            .AddPageRoute("/index", "/index/{id:int}");
    });

// Add DBContect to the project.
builder.Services.AddDbContext<eCapitalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("eCapitalContext") ?? throw new InvalidOperationException("Connection string 'eCapitalContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

var supportedCultures = new[]
{
 new CultureInfo("en-CA"),
 new CultureInfo("en-US"),
};

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-CA"),
    // Formatting numbers, dates, etc.
    SupportedCultures = supportedCultures,
    // UI strings that we have localized.
    SupportedUICultures = supportedCultures
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();