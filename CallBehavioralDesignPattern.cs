﻿using DesignPatternsTraining._BehavioralPatterns.MediatorDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.MementoDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.NullObjectDesignPattern.Implementations;
using DesignPatternsTraining._BehavioralPatterns.ObserverDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.RepositoryDesignPattern.Databases;
using DesignPatternsTraining._BehavioralPatterns.RepositoryDesignPattern.Repository;
using DesignPatternsTraining._BehavioralPatterns.StateDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern;
using DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern.Abstract;
using DesignPatternsTraining._BehavioralPatterns.StrategyDesignPattern.StrategyImplementations;
using DesignPatternsTraining._BehavioralPatterns.TemplateDesignPattern.Concreate;
using DesignPatternsTraining._BehavioralPatterns.VisitorDesignPattern.ConcreateVisitors;
using DesignPatternsTraining._BehavioralPatterns.VisitorDesignPattern.Employees;
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

        public static void State()
        {
            //Let's cook a steak!
            Steak account = new Steak("T-Bone");

            // Apply temperature changes
            account.AddTemp(120);
            account.AddTemp(15);
            account.AddTemp(15);
            account.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            account.RemoveTemp(15);
            account.AddTemp(20);
            account.AddTemp(20);
            account.AddTemp(20);
        }

        public static void Strategy()
        {
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?" +
                "\n Please choise: " + 
                "\n\n  1 - Grilling" +
                "\n  2 - Oven Baking" +
                "\n  3 - DeepFrying");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    StartCookingWithStrategy(cookMethod, new Grilling());
                    break;

                case 2:
                    StartCookingWithStrategy(cookMethod, new OvenBaking());
                    break;

                case 3:
                    StartCookingWithStrategy(cookMethod, new DeepFrying());
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
        }

        public static void Template()
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();
        }

        public static void Visitor()
        {
            // Who are my employees?
            Employees e = new Employees();
            e.Attach(new LineCookForVisitor());
            e.Attach(new HeadChefForVisitor());
            e.Attach(new GeneralManagerForVisitor());

            // Employees are visited, giving them 10% raises and 3 extra paid time off days.
            e.Accept(new IncomeVisitor());
            e.Accept(new PaidTimeOffVisitor());
        }

        public static void NullObject()
        {
            BasicDiscount basicDiscount = new BasicDiscount();
            NullDiscount nullDiscount = new NullDiscount();

            Console.WriteLine("Please enter price");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Discount calculation... " + "\nIs user registered? YES/NO" );
            string answer = Console.ReadLine().ToLowerInvariant();

            switch (answer)
            {
                case "yes":
                    Console.WriteLine("Customer discount eqauls: " + basicDiscount.Calculate(price));
                    break;
                case "no":
                    Console.WriteLine("Customer discount eqauls: " + nullDiscount.Calculate(price));
                    break;
                default:
                    break;
            }
        }

        public static void Repository()
        {
            RepositoryEmulation repository = new RepositoryEmulation();
            int id1 = 1;

            Console.WriteLine("Adding two contacts..");
            repository.SaveContact(new Contact().SetId(id1).SetName("Tolik").SetEmail("tolik@gmail.com"));
            repository.SaveContact(new Contact().SetId(2).SetName("Anatolii").SetEmail("anatolii@gmail.com"));

            Console.WriteLine("\nShowing all contacts");
            foreach (var contact in repository.GetContacts())
            {
                contact.ShowContactData();
            }

            Console.WriteLine("\nSaving contact with already exists ID");
            repository.SaveContact(new Contact().SetId(2).SetName("Vasia").SetEmail("vasia@gmail.com"));

            Console.WriteLine("\nShowing contact with ID = " + id1);
            repository.GetContactById(id1).ShowContactData();

            Console.WriteLine("\nTrying to find contact by not exist ID");
            Contact con = repository.GetContactById(99);
            if (con == null)
            {
                Console.WriteLine("No contact with a such ID");
            } 
            else
            {
                con.ShowContactData();
            }
        }


        #region Helpers

        private static void StartCookingWithStrategy(CookingMethod cookMethod, CookStrategy cookStrategy)
        {
            cookMethod.SetCookStrategy(cookStrategy);
            cookMethod.Cook();
        }

        #endregion
    }
}
