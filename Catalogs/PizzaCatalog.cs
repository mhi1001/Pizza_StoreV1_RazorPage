using Pizza_StoreV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV1.PizzaCatalogs
{
    public class PizzaCatalog
    {
        private static PizzaCatalog _instance;//Singleton Design Pattern
        private Dictionary<int, Pizza> pizzas { get; }

        private PizzaCatalog()//Singleton Design Pattern - changed it to private
        {
            pizzas = new Dictionary<int, Pizza>();
            pizzas.Add(1, new Pizza() { Id = 1, Name = "Cheese_pizza", Description = " Made of cheese", Price = 98, ImageName = "Cheeze_pizza.jfif" });
            pizzas.Add(2, new Pizza() { Id = 2, Name = "Bufalla_pizza", Description = " Made of bufalla", Price = 59, ImageName = "Bufalla_pizza.jfif" });
            pizzas.Add(3, new Pizza() { Id = 3, Name = "Chicken_pizza", Description = " Made of chicken", Price = 120, ImageName = "Chicken_pizza.jfif" });
            pizzas.Add(4, new Pizza() { Id = 4, Name = "Mozzarella_pizza", Description = " Made of mozzarella", Price = 77, ImageName = "Mozzarella_pizza.jfif" });
            pizzas.Add(5, new Pizza() { Id = 5, Name = "Vegetable_pizza", Description = " Made of vegetars", Price = 88, ImageName = "Vegetable_pizza.jfif" });
        }


        public Dictionary<int, Pizza> AllPizzas()
        {
            return pizzas;
        }

        public static PizzaCatalog Instance //Singleton Design Pattern added Instance Property if its null it will create a new if not it will use the current one
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PizzaCatalog();
                }

                return _instance;
            }
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza.Id, pizza);
        }

        public Pizza GetPizza(int id)
        {
            foreach (Pizza p in pizzas.Values)
            {
                if (id == p.Id)
                {
                    return p;
                }
            }
            return new Pizza();
        }

        public void UpdatePizza(Pizza @p)
        {
            if (@p != null)
            {
                foreach (Pizza pizza in pizzas.Values)
                {
                    if (pizza.Id == @p.Id)
                    {
                        pizza.Id = @p.Id;
                        pizza.Name = @p.Name;
                        pizza.ImageName = @p.ImageName;
                        pizza.Description = @p.Description;
                        pizza.Price = @p.Price;
                    }
                }

            }
        }
    }
}
