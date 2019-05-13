using System;

namespace Varelager
{
    public class ListItemsPage : IPage
    {
        public string Label => "List all items";
        private readonly Storage _storage;

        public ListItemsPage(Storage storage)
        {
            _storage = storage;
        }
        
        public void Execute()
        {
            var items = _storage.listAllItems();
            if (items.Length > 0)
            {
                Console.WriteLine("All items:");

                foreach (var item in items)
                    Console.WriteLine($" {item.Amount} of item named '{item.Name}'");
            }
            else
            {
                Console.WriteLine("No items.");
            }

            Prompt.PromptPageExit();
        }
    }
}