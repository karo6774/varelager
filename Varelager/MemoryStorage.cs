using System.Collections.Generic;
using System.Linq;

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

        public virtual bool AddItem(Item item)
        {
            if (Items.Any(it => it.Name == item.Name))
                return false;
            Items.Add(item);
            return true;
        }
    }
}