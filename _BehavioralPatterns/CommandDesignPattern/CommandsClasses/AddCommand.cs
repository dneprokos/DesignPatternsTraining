using System.Collections.Generic;

namespace DesignPatternsTraining.CommandDesignPattern.CommandsClasses
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
        }
    }
}
