using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts;
using System;

namespace DesignPatternsTraining._CreationalPatterns.SingletonDesignPattern.SingletonInTesting
{
    public class WebDriverInitializationThreadSafe
    {
        public static WebDriverInitializationThreadSafe Instance => instance.Value;
        private readonly ICustomWebDriver _driver = null;

        private WebDriverInitializationThreadSafe()
        {
            _driver = new KyivDriver();
        }

        //Lazy load Right now, our class is completely thread-safe. 
        //It is loaded in a lazy way which means that our instance is going to be created only when it is actually needed.
        private static Lazy<WebDriverInitializationThreadSafe> instance =
            new Lazy<WebDriverInitializationThreadSafe>(() => new WebDriverInitializationThreadSafe());

        public ICustomWebDriver GetDriver()
        {
            return _driver;
        }
    }
}
