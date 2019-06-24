namespace DesignPatternsTraining.FactoryMethod
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Warming(temperature);
    }
}
