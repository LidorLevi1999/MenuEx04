using Ex04.Menus.Interfaces.Interfaces;
using System;

namespace Ex04.Menus.Test.TestInterfaces
{
    internal class TestTime : IActionItem
    {
        public void Execute()
        {
            DateTime now = DateTime.Now;
            string formattedTime = now.ToString("HH:mm:ss");

            Console.WriteLine("The hour is " + formattedTime);
        }
    }
}
