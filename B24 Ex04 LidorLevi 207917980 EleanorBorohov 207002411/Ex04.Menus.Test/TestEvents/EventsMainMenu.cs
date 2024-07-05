using Ex04.Menus.Events;
using System;

namespace Ex04.Menus.Test.TestEvents
{
    public class EventsMainMenu
    {
        public MainMenu MainMenu { get; private set; }
        private const string k_Title = "Delegates Main Menu";
        public EventsMainMenu() 
        {
            MenuItem backMenuItem = new MenuItem("Back", 0);
            MenuItem exitMenuItem = new MenuItem("Exit", 0);
            SubMenuItem versionAndCapitalsMenuItem = new SubMenuItem("Version and Capitals", 1);
            MenuItem versionMenuItem = new MenuItem("Show Version", 1);
            MenuItem capitalsMenuItem = new MenuItem("Count Capitals", 2);
            SubMenuItem dateAndTimeMenuItem = new SubMenuItem("Show Date/Time", 2);
            MenuItem dateMenuItem = new MenuItem("Show Date", 1);
            MenuItem timeMenuItem = new MenuItem("Current Time", 2);

            MainMenu = new Events.MainMenu(k_Title);
            exitMenuItem.MenuItemSelected += exitMenu;
            versionMenuItem.MenuItemSelected += testVersion;
            capitalsMenuItem.MenuItemSelected += testCapitals;
            versionAndCapitalsMenuItem.AddSubMenuItem(versionMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(capitalsMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(backMenuItem);
            dateMenuItem.MenuItemSelected += testDate;
            timeMenuItem.MenuItemSelected += testTime;
            dateAndTimeMenuItem.AddSubMenuItem(dateMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(timeMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(backMenuItem);
            MainMenu.AddSubMenuItem(versionAndCapitalsMenuItem);
            MainMenu.AddSubMenuItem(dateAndTimeMenuItem);
            MainMenu.AddSubMenuItem(exitMenuItem);
        }

        private void testVersion() 
        {
            Console.WriteLine("App Version: 24.2.4.9504");
            Console.WriteLine();
        }

        private void testCapitals()
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
            Console.WriteLine();
        }

        private void testDate()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Date: " + now.ToString("MM/dd/yyyy"));
            Console.WriteLine();
        }

        private void testTime()
        {
            DateTime now = DateTime.Now;
            string formattedTime = now.ToString("HH:mm:ss");

            Console.WriteLine("The hour is " + formattedTime);
            Console.WriteLine();

        }

        private void exitMenu()
        {
            MainMenu.IsMenuPresented = false;
        }
    }
}
