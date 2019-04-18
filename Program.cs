using System;

namespace DesignPatternsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            CallDesignPattern.Singleton();

            CallDesignPattern.Factory();

            CallDesignPattern.Builder();

            CallDesignPattern.DependencyInjection();

            CallDesignPattern.AbstractFactory();

            Console.ReadLine();
        }
    }
}
