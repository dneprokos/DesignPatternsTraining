using DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.AbstractFactory;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryDesignPattern2.ConcreateFactory;
using DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageBuilderInterfaces;
using DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageBuilders;
using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverFactory;
using DesignPatternsTraining._CreationalPatterns.SingletonDesignPattern.Simple;
using DesignPatternsTraining.AbstractFactoryDesignPattern;
using DesignPatternsTraining.BuilderDesignPattern;
using DesignPatternsTraining.DependencyInjection;
using DesignPatternsTraining.FactoryMethod;
using DesignPatternsTraining.LazyInitializationDesignPattern;
using DesignPatternsTraining.PoolObjectDesignPattern;
using DesignPatternsTraining.PrototypeDesignPattern;
using DesignPatternsTraining.Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatternsTraining
{
    public class CallCreationalDesignPattern
    {
        public static void SingletonWithLazyInitialization()
        {
            var db = SingletonDataContainerWithLazyInit.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = SingletonDataContainerWithLazyInit.Instance;
            Console.WriteLine(db2.GetPopulation("London"));
        }

        public static void SingletonSimpleExample()
        {
            SingletonSimple db = SingletonSimple.Instance;
            SingletonSimple db2 = SingletonSimple.Instance;

            Console.WriteLine("Population of Kyiv equals: " + db.GetPopulation("Kyiv"));
            Console.WriteLine("Population of London equals: " + db2.GetPopulation("London"));

            var test1 = "test1";
            var test2 = "test2";

            Console.WriteLine("\n########Compare hash codes#########\n");

            Console.WriteLine("Is db hash code equal to db2 hashcode?: " 
                + (db.GetHashCode() == db2.GetHashCode()));
            Console.WriteLine("Is test1 hash code equal to test2 hashcode?: " 
                + (test1.GetHashCode() == test2.GetHashCode()));
        }

        public static void LazyBeforeDotNet4Example()
        {
            LazyBeforeDotNet4 instance = LazyBeforeDotNet4.GetInstance();
        }

        public static void FactoryMethod()
        {
            var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
            factory.Operate();
        }

        public static void FactoryMethodWithWebDriverExample()
        {
            Console.WriteLine("Please select what driver do you want to use?");
            string driverName = Console.ReadLine();
            Console.WriteLine(driverName);

            ICustomWebDriver driver = WebDriverFactory.CreateDriver(driverName);
            driver.Quit();
        }

        public static void Builder()
        {
            var products = new List<Product>
            {
                new Product { Name = "Monitor", Price = 200.50 },
                new Product { Name = "Mouse", Price = 20.41 },
                new Product { Name = "Keyboard", Price = 30.15}
            };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            Console.WriteLine(report);
        }

        public static void BuilderPatternDirector()
        {
            IOrderMessageBuilder buildDiscountOrder = 
                new OrderMessageBuilder(new List<string> { "Iphone", "AitPods" })
                .BuildDiscountOrder().SendMessage();
            
            IOrderMessageBuilder buildReatilOrder =
                new OrderMessageBuilder(new List<string> { "Iphone", "AitPods" })
                .BuildRetailOrder().SendMessage();


            IOrderMessageBuilder buildLimitedOrder =
                new OrderMessageBuilder(new List<string> { "Iphone", "AitPods" })
                .BuildOrderType("Limited").SendMessage();

        }

        public static void DependencyInjection()
        {
            ////Dependency Injection
            ///
            //Constructor injection example
            var googleEmailService = new GoogleEmailService();
            var userLogicConstructorInjection = new UserLogicConstructorInjection(googleEmailService);

            //Setter injection
            OutlookEmailService outlookEmailService = new OutlookEmailService();
            var userLogicSetter = new UserLogicSetterInjection()
            {
                EmailService = outlookEmailService
            };

            //Method injection
            OutlookEmailService outlookEmailService2 = new OutlookEmailService();
            var userLogicMethod = new UserLogicMethodInjection();
            userLogicMethod.Register("test@test.com", "Test12345", outlookEmailService);
        }

        public static void AbstractFactory()
        {
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());
        }

        public static void AbstractFactoryWithFood()
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;
            switch (input)
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;

                case 'C':
                    factory = new KidCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);
        }

        public static void PoolObjectCall()
        {
            //Get object first time and show data
            PooledObject po = Pool.GetObject();
            po.TempData = "Pool1";
            Console.WriteLine(po.TempData);
            Pool.ReleaseObject(po);

            //Show data doesn't exits after relese
            Console.WriteLine(po.TempData);

            //Get object second time
            PooledObject po2 = Pool.GetObject();
            po2.TempData = "Pool2";
            Console.WriteLine(po2.TempData);

        }

        public static void Prototype()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
        }
    }
}
