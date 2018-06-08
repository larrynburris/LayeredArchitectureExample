using StoreTracker.Core;
using StoreTracker.Infrastructure;
using System;

namespace StoreTracker.CLI
{
    public class ConsoleNotificationService : INewStoreNotifier
    {
        public void Notify(StoreModel model)
        {
            Console.WriteLine();
            Console.WriteLine($"----- {model.Name} opened in {model.City} -----");
            Console.WriteLine();
        }
    }
}
