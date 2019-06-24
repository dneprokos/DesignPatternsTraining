namespace DesignPatternsTraining.DecoratorDesignPattern.SecondImplementation
{
    public class TopingDecorator: PlainPizza
    {
        protected PlainPizza tempPizza;

        public TopingDecorator(PlainPizza newPizza)
        {
            tempPizza = newPizza;
        }

        public virtual string GetDescription()
        {
            return tempPizza.getDescription();
        }

        public virtual double GetCost()
        {
            return tempPizza.getCost();
        }
    }
}
