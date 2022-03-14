using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SimulithAuditAppUI.Areas.Identity;
using SimulithAuditAppUI.Data;

namespace SimulithAuditAppUI
{
  public static class RegisterServices
  {
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
      // Add services to the container.
      var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
      builder.Services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(connectionString));
      builder.Services.AddDatabaseDeveloperPageExceptionFilter();
      builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
          .AddEntityFrameworkStores<ApplicationDbContext>();
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
      builder.Services.AddSingleton<WeatherForecastService>();
      builder.Services.AddMemoryCache(); // Caching
    }
  }
}
