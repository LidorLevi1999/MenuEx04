namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenuItem
    {
        public int Index { get; private set; }

        public bool isMenuRunning { get; set; }

        public MainMenu(string i_Title) : base(i_Title, 0)
        {

        }
        public void Show()
        {
            isMenuRunning = true;

            while(isMenuRunning)
            {
                base.Select();
            }
        }
    }
}
