using System;
using System.Collections.Generic;

namespace DesignPatternsTraining.CommandDesignPattern
{
    /// <summary>
    /// The Receiver
    /// </summary>
    public class FastFoodOrder
    {
        public List<MenuItem> currentItems { get; set; }
        public FastFoodOrder()
        {
            currentItems = new List<MenuItem>();
        }

        public FastFoodOrder(List<MenuItem> menuItems)
        {
            currentItems = menuItems;
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.currentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach (var item in currentItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }
    }
}
