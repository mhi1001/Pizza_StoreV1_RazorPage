using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Interfaces;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.Services;


namespace Pizza_StoreV1
{
    public class GetAllPizzasModel : PageModel
    {
        private IPizzaRepository _catalog; 
        public Dictionary<int, Pizza> Pizzas { get; set; }
        [BindProperty(SupportsGet = true)]
        public String FilterCriteria { get; set; }


        public GetAllPizzasModel(IPizzaRepository repository)
        {
            _catalog = repository;
        }

        public IActionResult OnGet()
        {
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Pizzas = _catalog.FilterPizzas(FilterCriteria);
            }
            else
            {
                Pizzas = _catalog.AllPizzas(); //Singleton Design Pattern
            }
            return Page();
        }
    }
}