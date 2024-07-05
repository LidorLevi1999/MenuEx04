namespace Ex04.Menus.Events
{
    public class MainMenu : SubMenuItem
    {
        private const int k_Index = -1;
        public bool IsMenuPresented { get; set; }

        public MainMenu(string title) : base(title, k_Index)
        {
        }

        public void Show()
        {
            IsMenuPresented = true;
            while(IsMenuPresented)
            {
                base.Select();
            }
        }
    }
}
