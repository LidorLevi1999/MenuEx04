using Ex04.Menus.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class TestTime : IActionItem
    {
        public void Execute()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Hour: " + now.Hour);
        }
    }
}
