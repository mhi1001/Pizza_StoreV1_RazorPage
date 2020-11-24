using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.Models;

namespace Pizza_StoreV1.Interfaces
{
    public interface IPizzaRepository //Service Injection first step- create interface with all of
                                        //the catalog methods
    {
        public Dictionary<int, Pizza> GetAllPizzas();
        public void AddPizza(Pizza pizza);
        public Pizza GetPizza(int id);
        public void UpdatePizza(int id, Pizza @p);
        public void RemovePizza(int id);
        public Dictionary<int, Pizza> FilterPizzas(string criteria);
    }
}
