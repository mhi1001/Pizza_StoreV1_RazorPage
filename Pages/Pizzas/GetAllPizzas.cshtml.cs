using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;


namespace Pizza_StoreV1
{
    public class GetAllPizzasModel : PageModel
    {
        private PizzaCatalog _catalog; //Singleton Design Pattern  define it in every model that will need to call the PizzaCatalog class
        public Dictionary<int, Pizza> Pizzas { get; set; }

        public GetAllPizzasModel()
        {
            _catalog = PizzaCatalog.Instance; //Singleton Design Pattern (initialize it or create new if null (check the method in the class)
        }

        public IActionResult OnGet()
        {
           Pizzas = _catalog.AllPizzas(); //Singleton Design Pattern
            return Page();
        }
    }
}