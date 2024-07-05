using Ex04.Menus.Test.TestEvents;
using Ex04.Menus.Test.TestInterfaces;


namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InterfacesMainMenu mainMenuInterfaces = new InterfacesMainMenu();
            EventsMainMenu mainMenuEvents = new EventsMainMenu();

            mainMenuInterfaces.MainMenu.Show();
            mainMenuEvents.MainMenu.Show();
        }
    }
}
