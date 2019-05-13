using System;

namespace Varelager
{
    public class SearchPage : IPage
    {
        public string Label => "Search items";
        private readonly Storage _storage;

        public SearchPage(Storage storage)
        {
            _storage = storage;
        }
        
        public void Execute()
        {
            Console.WriteLine("Enter search keyword:");
            
            var keyword = Prompt.PromptString();
            var items = _storage.search(keyword);
            if (items.Length > 0)
                foreach (var item in items)
                    Console.WriteLine($" {item.Amount} of item named '{item.Name}'");
            else
                Console.WriteLine("No items matched the given keyword.");

            Prompt.PromptPageExit();
        }
    }
}