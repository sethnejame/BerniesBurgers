using BerniesBurgers.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerniesBurgers.Pages.Burgers
{
    public class DetailModel : PageModel
    {
        public Burger Burger { get; set; }
        
        public void OnGet()
        {
            
        }
    }
}