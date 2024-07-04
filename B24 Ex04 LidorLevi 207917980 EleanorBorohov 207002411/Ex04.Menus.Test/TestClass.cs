using System;

namespace Ex04.Menus.Test
{
    internal class TestClass
    {
        public void ShowVersion()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
        }

        public void CountCapitals()
        {
            string userInput;
            int amountOfCapitals = 0;

            Console.WriteLine("Please write a sentence and I'll tell you how much capital letters it contains");
            userInput = Console.ReadLine();
            foreach(char c in userInput)
            {
                if (Char.IsUpper(c))
                {
                    amountOfCapitals++;
                }
            }

            Console.WriteLine(String.Format("Your sentence contains {0} capital letters", amountOfCapitals));
        }

        public void ShowTime()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Hour: " + now.Hour);
        }

        public void ShowDate()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Date: " + now.ToString("MM/dd/yyyy"));
        }

    }
}
