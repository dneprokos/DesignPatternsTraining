using DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.AbstractFactory;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.ConcreteProducts.Childs;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.ConcreateFactory
{
    public class KidCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }

        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }
    }
}
