using StoreTracker.Core;
using StoreTracker.Infrastructure;
using System;
using System.Collections.Generic;

namespace StoreTracker.Business
{
    public class StoreService : IStoreModelService
    {
        public INewStoreNotifier Notifier { get; set; }
        public IStoreModelRepository Repository { get; set; }

        public StoreService(INewStoreNotifier notifier, IStoreModelRepository repository)
        {
            Notifier = notifier;
            Repository = repository;
        }

        public List<StoreModel> GetAllStores()
        {
            return Repository.GetAll();
        }

        public void OnStoreOpened(StoreModel openedStore)
        {
            Repository.Add(openedStore);
            Notifier.Notify(openedStore);
        }

        public void OnStoreClosed(StoreModel closedStore)
        {
            Repository.Delete(closedStore);
        }
    }
}
