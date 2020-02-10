using DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct;
using System;

namespace DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.WebDriverProducts
{
    public class KyivDriver : ICustomWebDriver
    {
        private string text = "KyivDriver";

        public void Get(string url)
        {
            Console.WriteLine(string.Format("User opens {0} page", url));
        }

        public string GetTitle()
        {
            var title = string.Format("{0} title", text);

            Console.WriteLine(title);
            return title;
        }

        public void Quit()
        { 
            Console.WriteLine(string.Format("Quit {0} driver", text));
        }
    }
}
