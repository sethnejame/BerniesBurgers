using BerniesBurgers.Core;
using BerniesBurgers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerniesBurgers.Pages.Burgers
{
    public class DetailModel : PageModel
    {
        private readonly IBurgerData _burgerData;
        public Burger Burger { get; set; }

        public DetailModel(IBurgerData burgerData)
        {
            _burgerData = burgerData;
        }
        
        public IActionResult OnGet(int burgerId)
        {
            Burger = _burgerData.GetById(burgerId);
            if (Burger == null)
                RedirectToPage("./NotFound");
            return Page();
        }
    }
}