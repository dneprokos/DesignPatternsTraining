namespace DesignPatternsTraining.AbstractFactoryDesignPattern
{
    public interface IMobilePhone
    {
        /*
         * The Abstract Factory Pattern is a Creational pattern 
         * in which interfaces are defined for creating families 
         * of related objects without specifying their actual implementations.

           When using this pattern, you create factories which return 
           many kinds of related objects. This pattern enables larger architectures 
           such as Dependency Injection.
        */
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
