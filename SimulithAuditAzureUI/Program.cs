using Microsoft.AspNetCore.Rewrite;
using SimulithAuditAzureUI;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

// Order important
// Login
app.UseAuthentication();

// Check permissions
app.UseAuthorization();

// redirect to home page
app.UseRewriter(new RewriteOptions().Add(
  context=>
  {
    if(context.HttpContext.Request.Path == "/MicrosoftIdentity/Account/SignedOut")
    {
      context.HttpContext.Response.Redirect("/");
    }
  }));
app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();




// FIle upload https://www.meziantou.net/file-upload-with-progress-bar-in-blazor.htm