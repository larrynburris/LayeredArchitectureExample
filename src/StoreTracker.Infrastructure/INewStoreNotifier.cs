using StoreTracker.Core;

namespace StoreTracker.Infrastructure
{
    public interface INewStoreNotifier
    {
        void Notify(StoreModel model);
    }
}
