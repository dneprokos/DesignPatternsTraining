using System;

namespace DesignPatternsTraining.DesignDecoratorPattern
{
    class ConcreteDecoratorA : AbstractDecorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
