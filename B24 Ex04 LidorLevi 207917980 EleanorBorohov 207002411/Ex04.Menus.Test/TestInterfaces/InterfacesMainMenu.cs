
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class InterfacesMainMenu
    {
        public MainMenu MainMenu { get; private set; }
        private const string k_Title = "Interfaces Main Menu";

        public InterfacesMainMenu() 
        {
            ActionMenuItem backMenuItem = new ActionMenuItem("Back", 0);
            ActionMenuItem exitMenuItem = new ActionMenuItem("Exit", 0);
            SubMenuItem versionAndCapitalsMenuItem = new SubMenuItem("Version and Capitals", 1);
            ActionMenuItem versionMenuItem = new ActionMenuItem("Show Version", 1);
            ActionMenuItem capitalsMenuItem = new ActionMenuItem("Count Capitals", 2);
            SubMenuItem dateAndTimeMenuItem = new SubMenuItem("Show Date/Time", 2);
            ActionMenuItem dateMenuItem = new ActionMenuItem("Show Date", 1);
            ActionMenuItem timeMenuItem = new ActionMenuItem("Current Time", 2);

            MainMenu = new Interfaces.MainMenu(k_Title);
            exitMenuItem.AddListener(new TestExitMenu(MainMenu));
            versionMenuItem.AddListener(new TestVersion());
            capitalsMenuItem.AddListener(new TestCapitals());
            versionAndCapitalsMenuItem.AddSubMenuItem(versionMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(capitalsMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(backMenuItem);
            dateMenuItem.AddListener(new TestDate());
            timeMenuItem.AddListener(new TestTime());
            dateAndTimeMenuItem.AddSubMenuItem(dateMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(timeMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(backMenuItem);
            MainMenu.AddSubMenuItem(versionAndCapitalsMenuItem);
            MainMenu.AddSubMenuItem(dateAndTimeMenuItem);
            MainMenu.AddSubMenuItem(exitMenuItem);
        }
    }
}
