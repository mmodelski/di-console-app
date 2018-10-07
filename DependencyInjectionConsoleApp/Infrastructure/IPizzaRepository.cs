using DependencyInjectionConsoleApp.Domain;

namespace DependencyInjectionConsoleApp.Infrastructure
{
	public interface IPizzaRepository
	{
		Pizza GetPizza(int id);
	}
}
