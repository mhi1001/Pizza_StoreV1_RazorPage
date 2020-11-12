using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Bson;
using Pizza_StoreV1.Models;
using Pizza_StoreV1.PizzaCatalogs;

namespace Pizza_StoreV1.Pages.Pizzas
{
    public class EditPizzaModel : PageModel
    {
        private PizzaCatalog _catalog;
        [BindProperty]
        public Pizza Pizza { get; set; }

        public EditPizzaModel() //PEDRO OFC ITS GONNA CRASH WHEN YOU EDIT,IF YOU DONT INITIALIZE THE INSTANCE ON THE EDIT MODEL!!!!!
                                //SINGLETON DESIGNNNNNNNNNN
        {
                _catalog = PizzaCatalog.Instance;
        }
        public IActionResult OnGet(int id) ///ID (OnPOST method can bind automatically the querystring (in this case Id=??)
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
            _catalog.UpdatePizza(id,Pizza);
            return Redirect("GetAllPizzas");
        }
    }
}
