using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;

namespace Pizza_StoreV1.Pages.Pizzas
{
    public class CreatePizzaModel : PageModel
    {
        private PizzaCatalog _catalog;//Singleton Design Pattern, define it in every model that will need to call the PizzaCatalog class
        [BindProperty]
        public Pizza Pizza { get; set; }

        public CreatePizzaModel() 
        {
            _catalog = PizzaCatalog.Instance;//Singleton Design Pattern (initialize it or create new if null (check the method in the class)
        }
        
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _catalog.AddPizza(Pizza); //Adding the pizza property
            return Redirect("GetAllPizzas");
        }
    }
}
