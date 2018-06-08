using StoreTracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreTracker.Infrastructure
{
    public interface IStoreModelProvider
    {
        StoreModel GetOpenedStore();
        StoreModel GetClosedStore(List<StoreModel> storeModels);
    }
}
