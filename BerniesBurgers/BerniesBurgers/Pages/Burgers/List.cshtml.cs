using System.Collections.Generic;
using BerniesBurgers.Core;
using BerniesBurgers.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace BerniesBurgers.Pages.Burgers
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public IEnumerable<Burger> Burgers { get; set; }

        private readonly IConfiguration config;
        private readonly IBurgerData burgerData;

        public ListModel(IConfiguration config, IBurgerData burgerData)
        {
            this.burgerData = burgerData;
            this.config = config;
        }
        public void OnGet(string searchTerm)
        {
            
            Message = config["Message"];
            Burgers = burgerData.GetBurgersByName(searchTerm);
        }
    }
}