namespace DesignPatternsTraining._CreationalPatterns.FactoryMethodPatternWebDriverCustom.AbstractProduct
{
    public interface ICustomWebDriver
    {
        void Get(string url);

        void Quit();

        string GetTitle();
    }
}
