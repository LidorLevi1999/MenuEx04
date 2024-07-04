using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class TestVersion : IActionItem
    {
        public void Execute()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
        }
    }
}
