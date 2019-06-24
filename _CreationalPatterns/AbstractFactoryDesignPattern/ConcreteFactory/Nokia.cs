using DesignPatternsTraining.AbstractFactoryDesignPattern.Product;

namespace DesignPatternsTraining.AbstractFactoryDesignPattern
{
    public class Nokia : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
