using Ex04.Menus.Interfaces.Interfaces;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : IMenuItem
    {
        public string Title { get; private set; }
        public int Index { get; private set; }
        public List<IActionItem> Listeners { get; private set; }
        public void Select()
        {
            foreach (IActionItem listener in Listeners)
            {
                listener.Execute();
                System.Console.WriteLine();
            }
        }

        public void AddListener(IActionItem i_Listener)
        {
            Listeners.Add(i_Listener);   
        }

        public void RemoveListener(IActionItem i_Listener)
        {
            if (Listeners.Contains(i_Listener))
            {
                Listeners.Remove(i_Listener);
            }
        }

        public ActionMenuItem(string i_Title, int i_Index)
        {
            this.Title = i_Title;
            this.Index = i_Index;
            this.Listeners = new List<IActionItem>(); 
        }
    }
}
