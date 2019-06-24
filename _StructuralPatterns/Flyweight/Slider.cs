namespace DesignPatternsTraining.Flyweight
{
    public abstract class Slider
    {
        protected string Name;
        protected string Cheese;
        protected string Toppings;
        protected decimal Price;

        public abstract void Display(int orderTotal);
    }
}
