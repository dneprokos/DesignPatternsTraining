using System;

namespace DesignPatternsTraining._BehavioralPatterns.TemplateDesignPattern
{
    /// <summary>
    /// The AbstractClass participant which contains the template method.
    /// </summary>
    public abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        // The template method
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}
