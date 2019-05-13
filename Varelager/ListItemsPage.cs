using System;

namespace Varelager
{
    public class ListItemsPage : IPage
    {
        public string Label => "List all items";
        private readonly IStorage _storage;

        public ListItemsPage(IStorage storage)
        {
            _storage = storage;
        }
        
        public void Execute()
        {
            var items = _storage.ListAllItems();
            if (items.Length > 0)
            {
                Console.WriteLine("All items:");

                foreach (var item in items)
                    Console.WriteLine($" {item}");
            }
            else
                Console.WriteLine("No items.");

            Console.WriteLine();
            Prompt.PromptPageExit();
        }
    }
}