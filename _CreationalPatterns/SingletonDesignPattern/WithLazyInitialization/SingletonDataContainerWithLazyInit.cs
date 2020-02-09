using System;
using System.Collections.Generic;

namespace DesignPatternsTraining.Singleton
{
    public class SingletonDataContainerWithLazyInit: ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        private SingletonDataContainerWithLazyInit()
        {
            Console.WriteLine("Initializing singleton object");

            _capitals.Add("Washington, D.C.", 702455);
            _capitals.Add("London", 8136000);
            _capitals.Add("Kyiv", 2884000);
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

        //Lazy load Right now, our class is completely thread-safe. 
        //It is loaded in a lazy way which means that our instance is going to be created only when it is actually needed.
        private static Lazy<SingletonDataContainerWithLazyInit> instance = 
            new Lazy<SingletonDataContainerWithLazyInit>(() => new SingletonDataContainerWithLazyInit());

        public static SingletonDataContainerWithLazyInit Instance => instance.Value;
    }
}
