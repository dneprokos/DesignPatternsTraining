using DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern.Abstract;
using System;

namespace DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    public class CookingMethod
    {
        private string Food;
        private CookStrategy _cookStrategy;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
