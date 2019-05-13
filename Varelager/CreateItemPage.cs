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
            string name;
            while ((name = Prompt.PromptString()).Length <= 0)
                Console.WriteLine("Item name must be at least one character long.");

            Console.WriteLine();
            Console.WriteLine("Enter amount of the new item:");
            int amount;
            while ((amount = Prompt.PromptInt()) < 0)
                Console.WriteLine("Amount must be positive.");

            var item = new Item(name, amount);
            _storage.addItem(item);

            Console.WriteLine($"Created {amount} of item named '{name}'.");
            Console.WriteLine();

            Prompt.PromptPageExit();
        }
    }
}