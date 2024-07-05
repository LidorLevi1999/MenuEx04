using System;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        public string Title { get; private set; }
        public int Index { get; private set; }
        public event Action MenuItemSelected;

        public MenuItem(string i_Title, int i_Index)
        {
            this.Title = i_Title;
            this.Index = i_Index;
        }

        public virtual void Select()
        {
            OnSelected();
        }

        protected virtual void OnSelected()
        {
            MenuItemSelected?.Invoke();
        }
    }
}
