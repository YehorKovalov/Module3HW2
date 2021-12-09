using System;
using ContactList.Services;
using ContactList.Services.Abstractions;
using ContactList.UI;
using Microsoft.Extensions.DependencyInjection;

namespace ContactList
{
    public class Startup
    {
        public void Run()
        {
            var serviceProvider = ConfigureServices();
            var app = serviceProvider?.GetService<Application>();
            app?.Run();
        }

        private IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IFileServices, FileServices>();
            serviceCollection.AddSingleton<IConfigServices, ConfigServices>();
            serviceCollection.AddSingleton<IContactListManager, ContactListManager>();
            serviceCollection.AddSingleton<IAlphabetServices, AlphabetServices>();
            serviceCollection.AddTransient<IUI, ConsoleManager>();
            serviceCollection.AddTransient<Application>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
