﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Interfaces
{
     public class SubMenuItem : ISubMenuItem
    {
        public List<IMenuItem> SubItems { get; private set; }

        public string Title { get; private set; }

        public int Index {  get; private set; }

        public void AddSubMenuItem(IMenuItem i_Item)
        {
            if (SubItems.Any(subItem => subItem.Index == i_Item.Index))
            {
                throw new InvalidOperationException($"An item with index {i_Item.Index} already exists.");
            }

            SubItems.Add(i_Item);

            SubItems = SubItems
                .OrderBy(subItem => subItem.Index == 0 ? int.MaxValue : subItem.Index)
                .ToList();
        }

        public virtual void Show()
        {
            int userInput;
            Console.WriteLine(Title);
            Console.WriteLine("===============");
            foreach (IMenuItem item in SubItems)
            {
                Console.WriteLine(String.Format("{0}. {1}", item.Index, item.Title));
            }

            Console.WriteLine(String.Format("Please enter your choice (1-{0} or 0 to exit)", SubItems.Count));
            userInput = getUserInput();

            stepInto(userInput);

        }

        public SubMenuItem(string i_Title, int i_Index)
        {
            this.Title = i_Title;
            this.Index = i_Index;
            SubItems = new List<IMenuItem>();
        }

        protected void stepInto(int i_Index)
        {
            (SubItems.Find(item => item.Index == i_Index) as ISubMenuItem).Show();
        }

        protected int getUserInput()
        {
            string userInput = Console.ReadLine();
            int o_userInputAsIntegar;

            while (!int.TryParse(userInput, out o_userInputAsIntegar) || !isUserInputValid(o_userInputAsIntegar))
            {
                Console.WriteLine("Invalid input, please enter a valid integer number.");
                userInput = Console.ReadLine();
            }

            //TODO : Handle Back.
            return (o_userInputAsIntegar);
        }

        protected bool isUserInputValid(int i_UserInput)
        {
            return i_UserInput >= 0 && i_UserInput <= SubItems.Count;
        }

    }
}