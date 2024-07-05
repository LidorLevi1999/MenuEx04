using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class TestExitMenu : IActionItem
    {
        MainMenu m_MainMenu;

        public TestExitMenu(MainMenu i_MainMenu)
        {
            m_MainMenu = i_MainMenu;
        }

        public void Execute()
        {
            m_MainMenu.IsMenuPresented = false;
        }
    }
}
