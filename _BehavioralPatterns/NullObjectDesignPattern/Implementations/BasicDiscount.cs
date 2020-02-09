using DesignPatternsTraining._BehavioralPatterns.NullObjectDesignPattern.Interface;

namespace DesignPatternsTraining._BehavioralPatterns.NullObjectDesignPattern.Implementations
{
    public class BasicDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            return (price * 0.2);
        }
    }
}
