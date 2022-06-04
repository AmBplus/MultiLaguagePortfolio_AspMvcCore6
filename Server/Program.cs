// **************************************************

using Infrastructure.Middlewares;
using Microsoft.EntityFrameworkCore;
using Server;
using Settings;
using ConnectionStrings = Resources.ConnectionStrings;

//WebApplicationOptions webApplicationOptions =
//    new()
//    {
//        //EnvironmentName =
//        //	Microsoft.Extensions.Hosting.Environments.Production,

//        EnvironmentName =
//            Environments.Production
//    };
WebApplicationOptions webApplicationOptions =
    new()
    {
        //EnvironmentName =
        //	Microsoft.Extensions.Hosting.Environments.Production,

        //EnvironmentName =
        //    Environments.Production
    };
WebApplicationBuilder builder =
    WebApplication.CreateBuilder(webApplicationOptions);
builder.Services.AddDbContextPool<PortfolioContext>(op => op.UseSqlServer(ConnectionStrings.SqlServerConnectionSa));
builder.Services.AddControllersWithViews();

builder.Services.Configure<ApplicationSettings>
    (builder.Configuration.GetSection(ApplicationSettings.KeyName));

string? connectionString =
    builder.Configuration.GetConnectionString(ConnectionStrings.SqlServerConnectionSa);


WebApplication app =
    builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Errors/Error");


    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCultureCookie();


app.MapControllerRoute
(
    "defualt", "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

