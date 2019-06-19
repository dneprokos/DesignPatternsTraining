using DesignPatternsTraining.AbstractFactoryDesignPattern;
using DesignPatternsTraining.AdapterPattern;
using DesignPatternsTraining.BridgePattern;
using DesignPatternsTraining.BuilderDesignPattern;
using DesignPatternsTraining.ChainOfResponsibility;
using DesignPatternsTraining.CommandDesignPattern;
using DesignPatternsTraining.CompositePattern;
using DesignPatternsTraining.CompositePattern.SecondApproach;
using DesignPatternsTraining.DecoratorDesignPattern.SecondImplementation;
using DesignPatternsTraining.DependencyInjection;
using DesignPatternsTraining.DesignDecoratorPattern;
using DesignPatternsTraining.FacadeDesignPattern;
using DesignPatternsTraining.FactoryMethod;
using DesignPatternsTraining.Flyweight;
using DesignPatternsTraining.InterpreterDesignPattern;
using DesignPatternsTraining.IteratorDesignPattern;
using DesignPatternsTraining.LazyInitializationDesignPattern;
using DesignPatternsTraining.PoolObjectDesignPattern;
using DesignPatternsTraining.PrototypeDesignPattern;
using DesignPatternsTraining.Proxy;
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

        public static void CompositeTwoOrMusicGenerator()
        {
            SongComponent industrialMusic = new SongGroup("Industrial", "Some industial music");
            SongComponent heavyMetalMusic = new SongGroup("Heavy Metal Music", "Some Heavy Metal Music");

            SongComponent everySong = new SongGroup("Song list", "Every Song Available");

            everySong.Add(industrialMusic);

            industrialMusic.Add(new Song("Some Hit", "LALA", 1990));
            industrialMusic.Add(new Song("Some other Hit", "LOLO", 1990));

            industrialMusic.Add(heavyMetalMusic);

            heavyMetalMusic.Add(new Song("Hard Rock Aliluia", "Hard", 1980));
            heavyMetalMusic.Add(new Song("Hard Rock Aliluia 2", "Hard2", 1981));

            DiskJokey crazyKostas = new DiskJokey(everySong);

            crazyKostas.GetSongList();
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

        public static void DecoratorTwoOrPizzaMaker()
        {
            PlainPizza pizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
            Console.WriteLine(pizza.getDescription());
            Console.WriteLine(pizza.getCost());
        }

        public static void FacadeCall()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }

        public static void Flyweight()
        {
            Console.WriteLine("Please enter your slider order (use characters B, V, Z with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }
        }

        public static void Proxy()
        {
            var proxy = new NewServerProxy();
            var order = "Order_01"; 
            proxy.TakeOrder(order);
            proxy.DeliverOrder();
            proxy.TakeOrder(order);
        }

        public static void ChainOfResponsibility()
        {
            //Create the chain links
            Approver jennifer = new HeadChef();
            Approver mitchell = new PurchasingManager();
            Approver olivia = new GeneralManager();

            //Create the chain
            jennifer.SetSupervisor(mitchell);
            mitchell.SetSupervisor(olivia);

            // Generate and process purchase requests
            PurchaseOrder p = new PurchaseOrder(1, 20, 69, "Spices");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(3, 500, 4823.99, "Beef");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(4, 4, 12099, "Ovens");
            jennifer.ProcessRequest(p);
        }

        public static void CommandDesignPattern()
        {
            Patron patron = new Patron();
            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Remove the french fries
            patron.SetCommand(3 /*Remove*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Now we want 4 hamburgers rather than 2
            patron.SetCommand(2 /*Edit*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();
        }

        public static void Interpreter()
        {
            IExpression person1 = new TerminalExpression("Kushagra");
            IExpression person2 = new TerminalExpression("Lokesh");
            IExpression isSingle = new OrExpression(person1, person2);

            IExpression vikram = new TerminalExpression("Vikram");
            IExpression committed = new TerminalExpression("Committed");
            IExpression isCommitted = new AndExpression(vikram, committed);

            Console.WriteLine(isSingle.interpreter("Kushagra"));
            Console.WriteLine(isSingle.interpreter("Lokesh"));
            Console.WriteLine(isSingle.interpreter("Achint"));

            Console.WriteLine(isCommitted.interpreter("Committed, Vikram"));
            Console.WriteLine(isCommitted.interpreter("Single, Vikram"));
        }

        public static void Iterator()
        {
            // Build a collection of jelly beans
            JellyBeanCollection collection = new JellyBeanCollection();
            collection[0] = new JellyBean("Cherry");
            collection[1] = new JellyBean("Bubble Gum");
            collection[2] = new JellyBean("Root Beer");
            collection[3] = new JellyBean("French Vanilla");
            collection[4] = new JellyBean("Licorice");
            collection[5] = new JellyBean("Buttered Popcorn");
            collection[6] = new JellyBean("Juicy Pear");
            collection[7] = new JellyBean("Cinnamon");
            collection[8] = new JellyBean("Coconut");

            // Create iterator
            JellyBeanIterator iterator = collection.CreateIterator();

            Console.WriteLine("Gimme all the jelly beans!");

            for (JellyBean item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Flavor);
            }
        }

        
    }
}
