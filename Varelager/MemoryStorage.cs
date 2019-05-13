using System.Collections.Generic;

namespace Varelager
{
    public class MemoryStorage : IStorage
    {
        protected readonly List<Item> Items = new List<Item>();

        public virtual Item[] ListAllItems()
        {
            return Items.ToArray();
        }

        public virtual Item[] Search(string keyword)
        {
            var results = new List<Item>();
            foreach (var i in Items)
            {
                if (i.Name.ToLower().Contains(keyword.ToLower()))
                    results.Add(i);
            }

            return results.ToArray();
        }

        public virtual void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}