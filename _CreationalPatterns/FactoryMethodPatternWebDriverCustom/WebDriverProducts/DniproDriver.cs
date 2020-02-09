using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using System;

namespace DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts
{
    public class DniproDriver : ICustomWebDriver
    {
        private string driverName;

        public DniproDriver()
        {
            this.driverName = "DniproDriver";
        }

        public DniproDriver(string driverName)
        {
            this.driverName = driverName;
        }

        public void Get(string url)
        {
            Console.WriteLine(string.Format("User opens {0} page", url));
        }

        public string GetTitle()
        {
            return string.Format("{0} title", driverName);
        }

        public void Quit()
        {
            Console.WriteLine(string.Format("Quit {0} driver", driverName));
        }
    }
}
