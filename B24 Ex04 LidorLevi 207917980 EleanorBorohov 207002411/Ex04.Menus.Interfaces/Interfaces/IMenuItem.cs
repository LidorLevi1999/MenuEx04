namespace Ex04.Menus.Interfaces
{
    public interface IMenuItem
    {
        string Title { get; }
        int Index { get; }
        void Select();

    }
}
