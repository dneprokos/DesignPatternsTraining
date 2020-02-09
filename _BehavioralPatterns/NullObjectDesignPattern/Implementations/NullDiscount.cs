using DesignPatternsTraining._BehavioralPatterns.NullObjectDesignPattern.Interface;

namespace DesignPatternsTraining._BehavioralPatterns.NullObjectDesignPattern.Implementations
{
    public class NullDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            return 0;
        }
    }
}
