using DesignPatternsTraining.AdapterPattern;
using DesignPatternsTraining.BridgePattern;
using DesignPatternsTraining.CompositePattern;
using DesignPatternsTraining.CompositePattern.SecondApproach;
using DesignPatternsTraining.DecoratorDesignPattern.SecondImplementation;
using DesignPatternsTraining.DesignDecoratorPattern;
using DesignPatternsTraining.FacadeDesignPattern;
using DesignPatternsTraining.Flyweight;
using DesignPatternsTraining.Proxy;
using System;

namespace DesignPatternsTraining
{
    public class CallStructuralDesignPattern
    {
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
    }
}
