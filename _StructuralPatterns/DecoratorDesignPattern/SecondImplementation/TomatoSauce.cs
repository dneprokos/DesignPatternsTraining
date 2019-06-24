using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTraining.DecoratorDesignPattern.SecondImplementation
{
    public class TomatoSauce : TopingDecorator
    {
        public TomatoSauce(PlainPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
        }

        public override string GetDescription()
        {
            return tempPizza.getDescription() + "Tomato Sauce";
        }

        public override double GetCost()
        {
            return tempPizza.getCost() + .35;
        }
    }
}
