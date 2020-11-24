using Pizza_StoreV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizza_StoreV1.Interfaces;

namespace Pizza_StoreV1.Services
{
    public class PizzaCatalog : IPizzaRepository
    {
        
        private Dictionary<int, Pizza> Pizzas { get; }

        public PizzaCatalog() //removed every change done for the singleton and this class inherits the new Interface
        {
            Pizzas = new Dictionary<int, Pizza>();
            Pizzas.Add(1, new Pizza() { Id = 1, Name = "Cheese_pizza", Description = " Made of cheese", Price = 98, ImageName = "Cheeze_pizza.jfif" });
            Pizzas.Add(2, new Pizza() { Id = 2, Name = "Bufalla_pizza", Description = " Made of bufalla", Price = 59, ImageName = "Bufalla_pizza.jfif" });
            Pizzas.Add(3, new Pizza() { Id = 3, Name = "Chicken_pizza", Description = " Made of chicken", Price = 120, ImageName = "Chicken_pizza.jfif" });
            Pizzas.Add(4, new Pizza() { Id = 4, Name = "Mozzarella_pizza", Description = " Made of mozzarella", Price = 77, ImageName = "Mozzarella_pizza.jfif" });
            Pizzas.Add(5, new Pizza() { Id = 5, Name = "Vegetable_pizza", Description = " Made of vegetars", Price = 88, ImageName = "Vegetable_pizza.jfif" });
        }


        public Dictionary<int, Pizza> GetAllPizzas()
        {
            return Pizzas;
        }

   

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza.Id, pizza);
        }

        public Pizza GetPizza(int id)
        {
            foreach (Pizza p in Pizzas.Values)
            {
                if (id == p.Id)
                {
                    return p;
                }
            }
            return new Pizza();
        }

        public void UpdatePizza(int id, Pizza @p)
        {
            if (@p != null)
            {
                Pizzas[id] = @p;

            }
        }

        public void RemovePizza(int id)
        {
            Pizzas.Remove(id);
        }

        public Dictionary<int, Pizza> FilterPizzas(string criteria)
        {
            Dictionary<int, Pizza> emptyDictionary = new Dictionary<int, Pizza>();

            foreach (Pizza p in Pizzas.Values)
            {
                if (p.Name.StartsWith(criteria))
                {
                    emptyDictionary.Add(p.Id, p);
                }
            }

            return emptyDictionary;
        }
    }
}
