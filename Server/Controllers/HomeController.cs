using System.Diagnostics;
using Infrastructure.Middlewares;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Server.Models;
using Settings;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOptions
            <ApplicationSettings> applicationSettingsOptions)
        {
            ApplicationSettings =
                applicationSettingsOptions.Value;
        }

        private ApplicationSettings ApplicationSettings { get; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ChangeCulture(string? cultureName)
        {
            RequestHeaders? typedHeaders =
                HttpContext.Request.GetTypedHeaders();

            string? httpReferer =
                typedHeaders?.Referer?.AbsoluteUri;

            if (string.IsNullOrWhiteSpace(httpReferer)) return RedirectToAction("Index");
            string? defaultCultureName =
                ApplicationSettings.CultureSettings?.DefaultCultureName;
            List<string>? supportedCultureNames =
                ApplicationSettings.CultureSettings?.SupportedCultureNames?
                    .ToList();
            if (string.IsNullOrWhiteSpace(cultureName))
                cultureName =
                    defaultCultureName;
            if (supportedCultureNames == null ||
                supportedCultureNames.Contains(cultureName!) == false)
                cultureName =
                    defaultCultureName;
            CultureCookieHandlerMiddleware.SetCulture(cultureName);
            CultureCookieHandlerMiddleware
                .CreateCookie(HttpContext, cultureName!);
            return Redirect(httpReferer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}