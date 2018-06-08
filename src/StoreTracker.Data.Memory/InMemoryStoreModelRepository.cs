using StoreTracker.Core;
using StoreTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreTracker.Data.Memory
{
    public class InMemoryStoreModelRepository : IStoreModelRepository
    {
        public List<StoreModel> Models { get; set; }

        public InMemoryStoreModelRepository()
        {
            Models = new List<StoreModel>();
        }

        public void Add(StoreModel model)
        {
            Models.Add(model);
        }

        public void Delete(StoreModel model)
        {
            if (Models.Any(m => m.Id == model.Id))
                Models.Remove(model);
        }

        public StoreModel Get(Guid id)
        {
            return Models.FirstOrDefault(m => m.Id == id);
        }

        public List<StoreModel> GetAll()
        {
            return Models;
        }

        public IEnumerable<StoreModel> GetByCity(string city)
        {
            return Models.Where(m => m.City == city).ToList();
        }

        public List<StoreModel> GetByCity2(string city)
        {
            var models = new List<StoreModel>();
            foreach(var model in Models)
            {
                if(model.City == city)
                    models.Add(model);
            }
            return models;
        }

        public void Update(StoreModel model)
        {
            var memoryModel = Get(model.Id);
            memoryModel.Update(model);
        }
    }
}
