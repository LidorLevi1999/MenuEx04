using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    internal interface ISubMenuItem : IMenuItem
    {
        List<IMenuItem> SubItems { get; }

        void Show();

        void AddSubMenuItem(IMenuItem i_Item);
    }
}
