using System.Collections.Generic;

namespace Varelager
{
    public class MemoryStorage : Storage
    {
        protected readonly List<Item> Items = new List<Item>();

        public virtual Item[] listAllItems()
        {
            return Items.ToArray();
        }

        public virtual Item[] search(string keyword)
        {
            var results = new List<Item>();
            foreach (var i in Items)
            {
                if (i.Name.ToLower().Contains(keyword.ToLower()))
                    results.Add(i);
            }

            return results.ToArray();
        }

        public virtual void addItem(Item item)
        {
            Items.Add(item);
        }
    }
}