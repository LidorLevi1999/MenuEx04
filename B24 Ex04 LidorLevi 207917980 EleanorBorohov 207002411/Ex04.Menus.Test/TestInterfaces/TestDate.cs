using Ex04.Menus.Interfaces.Interfaces;
using System;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class TestDate : IActionItem
    {
        public void Execute()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Date: " + now.ToString("MM/dd/yyyy"));
        }
    }
}
