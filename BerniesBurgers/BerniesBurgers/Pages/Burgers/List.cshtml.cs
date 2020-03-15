using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace BerniesBurgers.Pages.Burgers
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }

        private readonly IConfiguration config;

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}