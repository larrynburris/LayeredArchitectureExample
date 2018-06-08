using StoreTracker.Core;
using System;
using System.Collections.Generic;

namespace StoreTracker.Infrastructure
{
    public interface IStoreModelRepository
    {
        StoreModel Get(Guid id);
        List<StoreModel> GetAll();
        void Add(StoreModel model);
        void Update(StoreModel model);
        void Delete(StoreModel model);
    }
}
