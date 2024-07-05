using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Events
{
    public class SubMenuItem : MenuItem
    {
        public List<MenuItem> SubItems { get; private set; }
        public SubMenuItem(string i_Title, int i_Index) : base(i_Title, i_Index)
        {
            this.SubItems = new List<MenuItem>();
            this.MenuItemSelected += subMenuItem_Selected;
        }

        public void AddSubMenuItem(MenuItem i_Item)
        {
            if(SubItems.Any(subItem => subItem.Index == i_Item.Index))
            {
                throw new InvalidOperationException($"An item with index {i_Item.Index} already exists.");
            }

            SubItems.Add(i_Item);
            SubItems = SubItems
                .OrderBy(subItem => subItem.Index == 0 ? int.MaxValue : subItem.Index)
                .ToList();
        }

        private void subMenuItem_Selected()
        {
            int userInput = -1;

            while (userInput != 0)
            {
                Console.WriteLine($"**{Title}**");
                Console.WriteLine("========================");
                foreach (var item in SubItems)
                {
                    Console.WriteLine($"{item.Index} -> {item.Title}");
                }

                Console.WriteLine($"Please enter your choice (1-{SubItems.Count - 1} or 0 to exit)");
                userInput = getUserInput();
                StepInto(userInput);
            }
        }
        
        protected void StepInto(int i_Index)
        {
            SubItems.Find(item => item.Index == i_Index)?.Select();
        }

        private int getUserInput()
        {
            string userInput = Console.ReadLine();
            int o_userInputAsInteger;

            while (!int.TryParse(userInput, out o_userInputAsInteger) || !isUserInputValid(o_userInputAsInteger))
            {
                Console.WriteLine("Invalid input, please enter a valid integer number.");
                userInput = Console.ReadLine();
            }

            return o_userInputAsInteger;
        }

        private bool isUserInputValid(int i_UserInput)
        {
            return i_UserInput >= 0 && i_UserInput <= (SubItems.Count - 1);
        }

    }
}