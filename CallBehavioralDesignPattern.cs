using DesignPatternsTraining._BehavioralPatterns.MediatorDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.MementoDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.ObserverDesignPattern;
using DesignPatternsTraining.ChainOfResponsibility;
using DesignPatternsTraining.CommandDesignPattern;
using DesignPatternsTraining.InterpreterDesignPattern;
using DesignPatternsTraining.IteratorDesignPattern;
using System;

namespace DesignPatternsTraining
{
    public class CallBehavioralDesignPattern
    {
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

            for (JellyBean item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Flavor);
            }
        }

        public static void Mediator()
        {
            ConcessionsMediator mediator = new ConcessionsMediator();

            NorthConcessionStand leftKitchen = new NorthConcessionStand(mediator);
            SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

            mediator.NorthConcessions = leftKitchen;
            mediator.SouthConcessions = rightKitchen;

            leftKitchen.Send("Can you send some popcorn?");
            rightKitchen.Send("Sure thing, Kenny's on his way.");

            rightKitchen.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
            leftKitchen.Send("Just a couple, we'll send Kenny back with them.");
        }

        public static void Memento()
        {
            //Here's a new supplier for our restaurant
            FoodSupplier s = new FoodSupplier();
            s.Name = "Harold Karstark";
            s.Phone = "(482) 555-1172";

            // Let's store that entry in our database.
            SupplierMemory m = new SupplierMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Address = "548 S Main St. Nowhere, KS";

            // Crap, gotta undo that entry, I entered the wrong address
            s.RestoreMemento(m.Memento);
        }

        public static void Observer()
        {
            // Create price watch for Carrots and attach restaurants that buy carrots from suppliers.
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;
        }
    }
}
