using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Interfaces;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;

namespace Pizza_StoreV1.Pages.Pizzas
{
    public class CreatePizzaModel : PageModel
    {

        [BindProperty]
        public Pizza Pizza { get; set; }

        private IPizzaRepository _catalog; //create the interface reference

        public CreatePizzaModel(IPizzaRepository repository) //inject the interface created
        {
            _catalog = repository;//And lastly Use this IPizzaRepository "repository" parameter to initialize the 
                                  // reference(named _catalog)
                                  //And then proceed to use the methods as we used to since 
                                  //did not changed the variable name 
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
