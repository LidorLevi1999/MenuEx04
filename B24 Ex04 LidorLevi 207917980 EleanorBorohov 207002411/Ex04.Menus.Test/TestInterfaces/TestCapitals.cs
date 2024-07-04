using Ex04.Menus.Interfaces.Interfaces;
using System;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class TestCapitals : IActionItem
    {
        public void Execute()
        {
            string userInput;
            int amountOfCapitals = 0;

            Console.WriteLine("Please write a sentence and I'll tell you how much capital letters it contains");
            userInput = Console.ReadLine();
            foreach (char c in userInput)
            {
                if (Char.IsUpper(c))
                {
                    amountOfCapitals++;
                }
            }

            Console.WriteLine(String.Format("Your sentence contains {0} capital letters", amountOfCapitals));
        }
    }
}
