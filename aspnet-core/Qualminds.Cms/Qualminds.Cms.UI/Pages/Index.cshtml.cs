using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace Qualminds.Cms.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            // Getting and Setting Session
            HttpContext.Session.SetString("IndexPage", "Home");

                int a = Convert.ToInt32(HttpContext.Session.GetString("IndexPage"));

            var message = $"Index page visited at {DateTime.Now.ToLongTimeString()}";
            _logger.LogInformation("Message displayed: {Message}", message);
        }
    }
}
