using DesignPatternsTraining.AbstractFactoryDesignPattern;
using DesignPatternsTraining.AdapterPattern;
using DesignPatternsTraining.BridgePattern;
using DesignPatternsTraining.BuilderDesignPattern;
using DesignPatternsTraining.CompositePattern;
using DesignPatternsTraining.DependencyInjection;
using DesignPatternsTraining.DesignDecoratorPattern;
using DesignPatternsTraining.FacadeDesignPattern;
using DesignPatternsTraining.FactoryMethod;
using DesignPatternsTraining.LazyInitializationDesignPattern;
using DesignPatternsTraining.PoolObjectDesignPattern;
using DesignPatternsTraining.PrototypeDesignPattern;
using DesignPatternsTraining.Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatternsTraining
{
    public class CallDesignPattern
    {
        public static void Singleton()
        {
            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = SingletonDataContainer.Instance;
            Console.WriteLine(db2.GetPopulation("London"));
        }

        public static void LazyBeforeDotNet4Example()
        {
            LazyBeforeDotNet4 instance = LazyBeforeDotNet4.GetInstance();
        }

        public static void Factory()
        {
            var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
            factory.Operate();
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

        public static void PoolObjectCall()
        {
            PooledObject po = Pool.GetObject();
            po.TempData = "Pool1";
            Console.WriteLine(po.TempData);

            Pool.ReleaseObject(po);
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

        public static void Adapter()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
        }

        public static void Bridge()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }

        public static void Composite()
        {
            // Create a tree structure

            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree

            root.Display(1);
        }

        public static void Decorator()
        {
            // Create ConcreteComponent and two Decorators

            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
        }

        public static void FacadeCall()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}
