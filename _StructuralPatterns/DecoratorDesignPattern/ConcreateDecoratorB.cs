using System;

namespace DesignPatternsTraining.DesignDecoratorPattern
{
    class ConcreteDecoratorB : AbstractDecorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
