using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class PizzaMenu
    {
        // instance field - liste af Pizzaer
        private readonly Dictionary<int,Pizza> _pizzaer = new Dictionary<int, Pizza>();

        public void Create(Pizza pizza)
        {
            _pizzaer.Add(pizza.Nummer, pizza);
        }

        public List<Pizza> ReadAll()
        {
            return new List<Pizza>(_pizzaer.Values);
        }

        public Pizza ReadPizza(int nummer)
        {
            if (_pizzaer.ContainsKey(nummer))
            {
                return _pizzaer[nummer];
            }

            return null;
        }

        public Pizza SearchPizza(int nummer)
        {
            return ReadPizza(nummer);
        }

        public void Update(Pizza pizza)
        {
            Pizza fundetPizza = ReadPizza(pizza.Nummer);
            if (fundetPizza is not null)
            {
                _pizzaer[pizza.Nummer] = pizza;
            }
            // else ingen opdatering
        }

        public Pizza Delete(int nummer)
        {
            Pizza fundetPizza = ReadPizza(nummer);
            if (fundetPizza is not null)
            {
                _pizzaer.Remove(nummer);
                return fundetPizza;
            }

            return null;
        }

        public string PrintMenu()
        {
            String str = "";

            foreach (Pizza p in _pizzaer.Values)
            {
                str = str + p.ToString() + "\n"; // indsætte ny linje mellem pizzaerne
            }


            return str;
        }

    }
}
