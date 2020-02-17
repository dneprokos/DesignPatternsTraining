using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts;
using System;

namespace DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverFactory
{
    public class WebDriverFactory
    {
        public static ICustomWebDriver CreateDriver(string driver)
        {
            ICustomWebDriver realDriver;
            string driverName = driver.ToLowerInvariant();

            switch (driverName)
            {
                case "kyivdriver":
                    realDriver = new KyivDriver();
                    break;
                case "dniprodriver":
                    realDriver = new DniproDriver();
                    break;
                case "":
                    realDriver = new KyivDriver();
                    Console.WriteLine("Driver cannot be empty. Driver was set to KyivDriver");
                    break;
                default:
                    realDriver = new KyivDriver();
                    Console.WriteLine("Driver cannot be null. Driver was set to KyivDriver");
                    break;

            }
            return realDriver;
        }
    }
}
