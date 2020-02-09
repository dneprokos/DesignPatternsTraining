using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using System;

namespace DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts
{
    public class KyivDriver : ICustomWebDriver
    {
        public void Get(string url)
        {
            Console.WriteLine(string.Format("User opens {0} page", url));
        }

        public string GetTitle()
        {
            return "KyivDriver title";
        }

        public void Quit()
        { 
            Console.WriteLine(string.Format("Quit KyivDriver driver"));
        }
    }
}
