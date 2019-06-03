namespace DesignPatternsTraining.Singleton
{
    public interface ISingletonContainer
    {
        /*
         * Singleton is a Creational design pattern in which a class 
         * is guaranteed to only ever have exactly one instance, with 
         * that instance being globally accessible.

           What this means is that the pattern forces a particular object 
           to not have an accessible constructor, and that any access performed 
           on the object is performed upon the same instance of that object.
         * */
        int GetPopulation(string name);
    }
}
