using System;
namespace DesignPatternsTraining.FactoryMethod
{
    public interface IAirConditioner
    {
        /*
         *The Factory Method pattern is a Creational pattern which defines 
         * an interface for creating an object, but doesn't specify what 
         * objects the individual implementations of that interface will instantiate.

           All that means is that when using this pattern, 
           you can define certain methods and properties of object 
           that will be common to all objects created using the Factory Method, 
           but let the individual Factory Methods define what specific objects 
           they will instantiate. 
         */
        void Operate();
    }
}
