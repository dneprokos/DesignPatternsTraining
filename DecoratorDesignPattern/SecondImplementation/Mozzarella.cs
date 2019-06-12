using System;

namespace DesignPatternsTraining.DecoratorDesignPattern.SecondImplementation
{
    public class Mozzarella : TopingDecorator
    {
        public Mozzarella(PlainPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");

            Console.WriteLine("Adding Moz");
        }

        public override string GetDescription()
        {
            return tempPizza.getDescription() + "Mozzarella";
        }

        public override double GetCost()
        {
            return tempPizza.getCost() + .5;
        }
    }
}
