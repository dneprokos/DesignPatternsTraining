namespace DesignPatternsTraining.DesignDecoratorPattern
{
    abstract class AbstractDecorator : AbstractComponent

    {
        protected AbstractComponent abstractComponent;

        public void SetComponent(AbstractComponent component)
        {
            this.abstractComponent = component;
        }

        public override void Operation()
        {
            if (abstractComponent != null)
            {
                abstractComponent.Operation();
            }
        }
    }
}
