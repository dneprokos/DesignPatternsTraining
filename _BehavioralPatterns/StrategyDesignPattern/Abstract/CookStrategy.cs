namespace DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern.Abstract
{
    /// <summary>
    /// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    public abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }
}
