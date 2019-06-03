using System;

namespace DesignPatternsTraining.AdapterPattern
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
