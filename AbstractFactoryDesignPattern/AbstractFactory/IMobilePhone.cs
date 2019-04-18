namespace DesignPatternsTraining.AbstractFactoryDesignPattern
{
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
