using BerniesBurgers.Core;
using BerniesBurgers.Data;
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
        
        public void OnGet(int burgerId)
        {
            Burger = _burgerData.GetById(burgerId);
        }
    }
}