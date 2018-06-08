using EasyConsole;
using StoreTracker.Core;
using StoreTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreTracker.ConsoleAPI
{
    public class ConsoleStoreProvider : IStoreModelProvider
    {
        public StoreModel GetClosedStore(List<StoreModel> storeModels)
        {
            if (!storeModels.Any())
            {
                Console.WriteLine("No models exist.");
                return null;
            }
            StoreModel closedStore = null;
            var menu = new Menu();
            foreach (var m in storeModels)
            {
                menu.Add(m.ToString(), () => 
                {
                    closedStore = m;
                });
            }
            menu.Display();
            return closedStore;
        }

        public StoreModel GetOpenedStore()
        {
            Console.WriteLine("Enter store name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter store city:");
            var city = Console.ReadLine();
            return new StoreModel(name, city);
        }
    }
}
