using Ex04.Menus.Events;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Test.TestInterfaces;
using System;


namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string interfacesMainMenuTitle = "Interfaces Main Menu";
            
            Interfaces.MainMenu mainMenuInterfaces = new Interfaces.MainMenu(interfacesMainMenuTitle);
            ActionMenuItem backMenuItem = new ActionMenuItem("Back", 0);
            ActionMenuItem exitMenuItem = new ActionMenuItem("Exit", 0);
            exitMenuItem.AddListener(new TestExitMenu(mainMenuInterfaces));

            SubMenuItem versionAndCapitalsMenuItem = new SubMenuItem("Version and Capitals", 1);
            ActionMenuItem versionMenuItem = new ActionMenuItem("Show Version", 1);
            versionMenuItem.AddListener(new TestVersion());
            ActionMenuItem capitalsMenuItem = new ActionMenuItem("Count Capitals", 2);

            capitalsMenuItem.AddListener(new TestCapitals());

            versionAndCapitalsMenuItem.AddSubMenuItem(versionMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(capitalsMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(backMenuItem);
            SubMenuItem dateAndTimeMenuItem = new SubMenuItem("Show Date/Time", 2);
            ActionMenuItem dateMenuItem = new ActionMenuItem("Show Date", 1);
            dateMenuItem.AddListener(new TestDate());
            ActionMenuItem timeMenuItem = new ActionMenuItem("Current Time", 2);
            timeMenuItem.AddListener(new TestTime());
            dateAndTimeMenuItem.AddSubMenuItem(dateMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(timeMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(backMenuItem);

            mainMenuInterfaces.AddSubMenuItem(versionAndCapitalsMenuItem);
            mainMenuInterfaces.AddSubMenuItem(dateAndTimeMenuItem);
            mainMenuInterfaces.AddSubMenuItem(exitMenuItem);

            mainMenuInterfaces.Show();
        }
    }
}
