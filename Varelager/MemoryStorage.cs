using System.Collections.Generic;

namespace Varelager
{
    public class MemoryStorage : Storage
    {
        private readonly List<Item> _items = new List<Item>();

        public Item[] listAllItems()
        {
            return _items.ToArray();
        }

        public Item[] search(string keyword)
        {
            var results = new List<Item>();
            foreach (var i in _items)
            {
                if (i.Name.ToLower().Contains(keyword.ToLower()))
                    results.Add(i);
            }

            return results.ToArray();
        }

        public void addItem(Item item)
        {
            _items.Add(item);
        }
    }
}