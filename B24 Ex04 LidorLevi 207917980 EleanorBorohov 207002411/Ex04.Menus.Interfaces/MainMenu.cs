namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenuItem
    {
        private const int k_Index = -1; 
        public bool IsMenuPresented { get; set; }
        public MainMenu(string i_Title) : base(i_Title, k_Index)
        {
        }

        public void Show()
        {
            IsMenuPresented = true;
            while(IsMenuPresented)
            {
                Select();
            }
        }
    }
}
