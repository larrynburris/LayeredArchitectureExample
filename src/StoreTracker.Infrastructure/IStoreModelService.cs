using StoreTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreTracker.Infrastructure
{
    public interface IStoreModelService
    {
        List<StoreModel> GetAllStores();
        void OnStoreClosed(StoreModel model);
        void OnStoreOpened(StoreModel model);
    }
}
