namespace DesignPatternsTraining.DecoratorDesignPattern.SecondImplementation
{
    public class PlainPizza : IPizza
    {
        public double getCost()
        {
            return 4.00;
        }

        public string getDescription()
        {
            return "Thin Dought";
        }
    }
}
