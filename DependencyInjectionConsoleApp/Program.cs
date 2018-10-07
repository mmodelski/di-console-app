using Microsoft.Extensions.DependencyInjection;
using DependencyInjectionConsoleApp.Infrastructure;
using NLog;
using System;

namespace DependencyInjectionConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = Startup.ConfigureApp();

			var pizzaService = serviceProvider.GetService<IPizzaService>();
			var pizza = pizzaService.GetPizza(1);

			var logger = LogManager.GetCurrentClassLogger();
			logger.Info($"Pizza");
			logger.Info($"Id: {pizza.Id}");
			logger.Info($"Name: {pizza.Name}");
			logger.Info($"Prive: {pizza.Price}");

			Console.ReadKey();
		}
	}
}
