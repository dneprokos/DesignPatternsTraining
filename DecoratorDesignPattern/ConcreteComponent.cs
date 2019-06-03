using System;

namespace DesignPatternsTraining.DesignDecoratorPattern
{
    class ConcreteComponent : AbstractComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
