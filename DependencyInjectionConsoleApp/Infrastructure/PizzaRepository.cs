using System.Collections.Generic;
using System.Linq;
using DependencyInjectionConsoleApp.Domain;

namespace DependencyInjectionConsoleApp.Infrastructure
{
	public class PizzaRepository : IPizzaRepository
	{
		private IEnumerable<Pizza> pizzaList = new List<Pizza>
		{
			new Pizza { Id = 1, Name = "Margherita", Price = 9M },
			new Pizza { Id = 2, Name = "Classic Pepperoni", Price = 10M },
			new Pizza { Id = 3, Name = "Extra Pepperoni", Price = 12M },
			new Pizza { Id = 4, Name = "Green Goddess", Price = 10M },
			new Pizza { Id = 5, Name = "Quattro Formaggi", Price = 10M }
		};

		public Pizza GetPizza(int id)
		{
			return pizzaList.FirstOrDefault(x => x.Id == id);
		}
	}
}
