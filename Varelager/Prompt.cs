using System;

namespace Varelager
{
    public class Prompt
    {
        public static string PromptString()
        {
            Console.Write(" > ");
            return Console.ReadLine();
        }

        public static int PromptInt()
        {
            Console.Write(" > ");
            int output;
            while (!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Please enter a number");
                Console.Write(" > ");
            }

            return output;
        }

        public static void PromptPageExit()
        {
            Console.Write("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}