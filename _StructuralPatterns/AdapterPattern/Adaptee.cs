using System;

namespace DesignPatternsTraining.AdapterPattern
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
