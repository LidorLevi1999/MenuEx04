using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenuItem
    {
        public int Index { get; private set; }

        public MainMenu(string i_Title) : base(i_Title, 0)
        {
            SubMenuItem exitItem = new SubMenuItem("Exit", 0);
            AddSubMenuItem(exitItem);
        }

        public override void Show()
        {
            bool isMenuStillRunning = true;
            int userInput;


            while(isMenuStillRunning)
            {
                base.Show();
            }
        }
    }
}
