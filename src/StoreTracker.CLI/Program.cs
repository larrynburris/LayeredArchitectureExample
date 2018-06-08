using EasyConsole;
using StoreTracker.Business;
using StoreTracker.ConsoleAPI;
using StoreTracker.Core;
using StoreTracker.Data.Csv;
using StoreTracker.Data.Memory;
using StoreTracker.Infrastructure;
using System;
using System.Linq;

namespace StoreTracker.CLI
{
    class Program
    {
        static IStoreModelProvider StoreModelProvider { get; set; } // UI Layer
        static IStoreModelService Service { get; set; } // Business Layer

        static void Main(string[] args)
        {


            StoreModelProvider = new ConsoleStoreProvider();
            Service = new StoreService(new ConsoleNotificationService(), new InMemoryStoreModelRepository());

            var menu = new Menu().Add("Store Opened Form", () => AddModel())
                                 .Add("Store Table", () => ListModels())
                                 .Add("Store Closed Form", () => DeleteModel());
            while(true)
            {
                menu.Display();
            }
        }
        
        private static void AddModel()
        {
            var model = StoreModelProvider.GetOpenedStore();
            Service.OnStoreOpened(model);
        }

        private static void DeleteModel()
        {
            var model = StoreModelProvider.GetClosedStore(Service.GetAllStores());
            Service.OnStoreClosed(model);
        }

        private static void ListModels()
        {
            var list = Service.GetAllStores();

            if (!list.Any())
            {
                Console.WriteLine("No models exist.");
                return;
            }

            foreach (var m in list)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
