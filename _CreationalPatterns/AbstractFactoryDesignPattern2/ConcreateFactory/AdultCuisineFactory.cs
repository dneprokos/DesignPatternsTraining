using DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.AbstractFactory;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.ConcreteProducts;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.ConcreateFactory
{
    public class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwich CreateSandwich()
        {
            return new Cheesesteak();
        }
    }
}
