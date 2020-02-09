using DesignPatternsTraining.Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatternsTraining._CreationalPatterns.SingletonDesignPattern.Simple
{
    public class SingletonSimple : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();
        private static SingletonSimple instance = null;

        private SingletonSimple()
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

        public static SingletonSimple Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonSimple();
                return instance;
            }
        }
    }
}
