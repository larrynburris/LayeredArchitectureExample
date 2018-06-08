using System;

namespace StoreTracker.Core
{
    public class StoreModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }

        public StoreModel(string name, string city)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"{nameof(name)} cannot be null or empty.");
            if (string.IsNullOrEmpty(city))
                throw new ArgumentException($"{nameof(city)} cannot be null or empty.");

            Name = name;
            City = city;
            Id = Guid.NewGuid();
        }

        public void Update(StoreModel model)
        {
            Name = model.Name;
        }

        public override string ToString()
        {
            return $"{Name} {City} {Id.ToString()}";
        }
    }
}
