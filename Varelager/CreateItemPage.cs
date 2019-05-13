using System;

namespace Varelager
{
    public class CreateItemPage : IPage
    {
        public string Label => "Create new item";
        private readonly Storage _storage;
        
        public CreateItemPage(Storage storage)
        {
            _storage = storage;
        }

        public void Execute()
        {
            Console.WriteLine("Enter a name for the new item:");
            var name = Prompt.PromptString();

            Console.WriteLine();
            Console.WriteLine("Enter amount of the new item:");
            var amount = Prompt.PromptInt();

            var item = new Item(name, amount);
            _storage.addItem(item);
            
            Console.WriteLine($"Created {amount} of item named '{name}'.");
            Console.WriteLine();
            
            Prompt.PromptPageExit();
        }
    }
}