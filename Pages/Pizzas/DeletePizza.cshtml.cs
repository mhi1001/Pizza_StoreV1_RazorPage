using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;

namespace Pizza_StoreV1.Pages.Pizzas
{
    public class DeletePizzaModel : PageModel
    {
        private PizzaCatalog _catalog;
        [BindProperty]
        public Pizza Pizza { get; set; }

        public DeletePizzaModel()
        {
            _catalog = PizzaCatalog.Instance;
        }
        public IActionResult OnGet(int id) //ID asp-for (OnPOST method can bind automatically the querystring (in this case Id=??)
        {
            Pizza = _catalog.GetPizza(id);
            return Page();
        }
        public IActionResult OnPost(int id)
        {
           _catalog.RemovePizza(id);
            return Redirect("GetAllPizzas");
        }

    }
}
