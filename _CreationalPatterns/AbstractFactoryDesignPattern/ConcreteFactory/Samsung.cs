using DesignPatternsTraining.AbstractFactoryDesignPattern.Product;

namespace DesignPatternsTraining.AbstractFactoryDesignPattern
{
    public class Samsung : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
