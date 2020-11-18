using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Bson;
using Pizza_StoreV1.Interfaces;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;

namespace Pizza_StoreV1.Pages.Pizzas
{
    public class EditPizzaModel : PageModel
    {
        private IPizzaRepository _catalog;
        [BindProperty]
        public Pizza Pizza { get; set; }

        public EditPizzaModel(IPizzaRepository repository)//And lastly Use this IPizzaRepository "repository" parameter to initialize the 
                                                          // reference(named _catalog)
                                                          //And then proceed to use the methods as we used to since 
                                                          //did not changed the variable name
        {
            _catalog = repository;
        }
        public IActionResult OnGet(int id) //ID (OnPOST method can bind automatically the querystring (in this case Id=??)
        {
            Pizza = _catalog.GetPizza(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _catalog.UpdatePizza(id, Pizza);
            return Redirect("GetAllPizzas");
        }
    }
}
