namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : IActionMenuItem
    {
        public string Title { get; private set; }

        public int Index { get; private set; }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public ActionMenuItem(string i_Title, int i_Index)
        {
            this.Title = i_Title;
            this.Index = i_Index;
        }
    }
}
