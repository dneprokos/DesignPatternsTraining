namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.AbstractFactory
{
    public abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }
}
