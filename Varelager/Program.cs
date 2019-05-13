using System;

namespace Varelager
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorage storage;
            if (args.Length >= 1)
                storage = FileStorage.LoadFromFile(args[0]);
            else
                storage = new MemoryStorage();
            
            var pages = new IPage[]
            {
                new CreateItemPage(storage),
                new ListItemsPage(storage),
                new SearchPage(storage)
            };
            
            while (true)
            {
                Console.WriteLine("Please choose an action:");
                for (var i = 0; i < pages.Length; i++)
                {
                    var page = pages[i];
                    Console.WriteLine($" {i + 1} - {page.Label}");
                }

                Console.WriteLine($" {pages.Length + 1} - Exit");

                int choice;
                while (true)
                {
                    choice = Prompt.PromptInt() - 1;
                    if (choice < 0 || choice > pages.Length)
                        Console.WriteLine($"Please enter a number between 1 and {pages.Length + 1}");
                    else break;
                }

                if (choice >= pages.Length)
                    break;

                Console.Clear();
                pages[choice].Execute();
                Console.Clear();
            }
        }
    }
}