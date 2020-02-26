using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractFactory;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractFactoryImplementation
{
    public class SetupDataBaseFactory
    {
        private IDataBaseSetupFactory factory;

        public SetupDataBaseFactory(IDataBaseSetupFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            factory.CreateAccountManager().CreateAccount();
            factory.CreateOrderManager().CreateOrder();
        }
    }
}
