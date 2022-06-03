using Infrastructure.Middlewares;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Settings;

namespace Server.Controllers
{
    public class ChangeCultureController : Controller
    {
        public ChangeCultureController(IOptions<ApplicationSettings> applicationSettings)
        {
            ApplicationSettings = applicationSettings.Value;
        }

        private ApplicationSettings ApplicationSettings { get; }

        public IActionResult Index(string name)
        {
            // **************************************************
            // GetTypedHeaders -> using Microsoft.AspNetCore.Http;
            RequestHeaders? typedHeaders =
                HttpContext.Request.GetTypedHeaders();

            string? httpReferer =
                typedHeaders?.Referer?.AbsoluteUri;

            if (string.IsNullOrWhiteSpace(httpReferer)) return RedirectToPage("/Index");
            // **************************************************

            // **************************************************
            string? defaultCultureName =
                ApplicationSettings.CultureSettings?.DefaultCultureName;

            List<string>? supportedCultureNames =
                    ApplicationSettings.CultureSettings?.SupportedCultureNames?
                        .ToList()
                ;
            // **************************************************

            // **************************************************
            if (string.IsNullOrWhiteSpace(name))
                name =
                    defaultCultureName;
            // **************************************************

            // **************************************************
            if (supportedCultureNames == null ||
                supportedCultureNames.Contains(name!) == false)
                name =
                    defaultCultureName;
            // **************************************************

            // **************************************************
            CultureCookieHandlerMiddleware.SetCulture(name);
            // **************************************************

            // **************************************************
            CultureCookieHandlerMiddleware
                .CreateCookie(HttpContext, name!);
            // **************************************************

            return Redirect(httpReferer);
        }
    }
}
