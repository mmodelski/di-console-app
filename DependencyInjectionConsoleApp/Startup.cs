using DependencyInjectionConsoleApp.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using System;

namespace DependencyInjectionConsoleApp
{
	public class Startup
	{
		public static IServiceProvider ConfigureApp()
		{
			var services = new ServiceCollection();

			services.AddSingleton<ILoggerFactory, LoggerFactory>();
			services.AddScoped<IPizzaRepository, PizzaRepository>();
			services.AddScoped<IPizzaService, PizzaService>();

			var serviceProvider = services.BuildServiceProvider();

			var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
			loggerFactory.AddNLog(new NLogProviderOptions { CaptureMessageTemplates = true, CaptureMessageProperties = true });
			LogManager.LoadConfiguration("nlog.config");

			return serviceProvider;
		}
	}
}
