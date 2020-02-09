using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts;

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
                default:
                    realDriver = new DniproDriver(driver);
                    break;

            }
            return realDriver;
        }
    }
}
