using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AKSExample.Client.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IConfiguration configuration;

        public string ApiUri { get; set; }

        public PrivacyModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void OnGet()
        {
            this.ApiUri = this.configuration["ApiUri"];
        }
    }
}
