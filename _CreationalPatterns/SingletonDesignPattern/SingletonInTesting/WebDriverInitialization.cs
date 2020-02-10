using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts;


namespace DesignPatternsTraining._CreationalPatterns.SingletonDesignPattern.SingletonInTesting
{
    public class WebDriverInitialization
    {
        private static WebDriverInitialization _instance = null;
        private readonly ICustomWebDriver _driver = null;

        private WebDriverInitialization()
        {
            _driver = new KyivDriver();
        }

        public static WebDriverInitialization Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WebDriverInitialization();
                return _instance;
            }
        }

        public ICustomWebDriver GetDriver() 
        {
            return _driver;
        }
    }
}
