using DependencyInjectionConsoleApp.Domain;

namespace DependencyInjectionConsoleApp.Infrastructure
{
	public class PizzaService : IPizzaService
	{
		private readonly IPizzaRepository _pizzaRepository;

		public PizzaService(IPizzaRepository pizzaRepository)
		{
			_pizzaRepository = pizzaRepository;
		}

		public Pizza GetPizza(int id)
		{
			return _pizzaRepository.GetPizza(id);
		}
	}
}
