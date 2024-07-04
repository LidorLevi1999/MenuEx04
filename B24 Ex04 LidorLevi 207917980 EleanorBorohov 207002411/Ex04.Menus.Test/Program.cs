using Ex04.Menus.Events;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string interfacesMainMenuTitle = "Interfaces Main Menu";
            
            Interfaces.MainMenu mainMenuInterfaces = new Interfaces.MainMenu(interfacesMainMenuTitle);

            SubMenuItem versionAndCapitalsMenuItem = new SubMenuItem("Version and Capitals", 1);
            ActionMenuItem versionMenuItem = new ActionMenuItem("Show Version", 1);
            ActionMenuItem capitalsMenuItem = new ActionMenuItem("Count Capitals", 2);

            versionAndCapitalsMenuItem.AddSubMenuItem(versionMenuItem);
            versionAndCapitalsMenuItem.AddSubMenuItem(capitalsMenuItem);

            SubMenuItem dateAndTimeMenuItem = new SubMenuItem("Show Date/Time", 2);
            ActionMenuItem dateMenuItem = new ActionMenuItem("Show Date", 1);
            ActionMenuItem timeMenuItem = new ActionMenuItem("Count Time", 2);

            dateAndTimeMenuItem.AddSubMenuItem(dateMenuItem);
            dateAndTimeMenuItem.AddSubMenuItem(timeMenuItem);

            mainMenuInterfaces.AddSubMenuItem(versionAndCapitalsMenuItem);
            mainMenuInterfaces.AddSubMenuItem(dateAndTimeMenuItem);

            mainMenuInterfaces.Show();
        }
    }
}
