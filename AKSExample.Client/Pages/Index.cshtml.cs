using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;

namespace AKSExample.Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient httpClient;

        public string MachineName { get; set; }

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient("AKSExample.Api");
        }

        public async Task OnGet()
        {
            var response = await this.httpClient.GetAsync("api/machine");
            var content = await response.Content.ReadAsStringAsync();
            this.MachineName = content;
        }
    }
}
