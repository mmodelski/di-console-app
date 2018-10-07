using DependencyInjectionConsoleApp.Domain;

namespace DependencyInjectionConsoleApp.Infrastructure
{
	public interface IPizzaService
	{
		Pizza GetPizza(int id);
	}
}
