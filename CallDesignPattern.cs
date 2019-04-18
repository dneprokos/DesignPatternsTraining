using DesignPatternsTraining.AbstractFactoryDesignPattern;
using DesignPatternsTraining.BuilderDesignPattern;
using DesignPatternsTraining.DependencyInjection;
using DesignPatternsTraining.FactoryMethod;
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
    }
}
