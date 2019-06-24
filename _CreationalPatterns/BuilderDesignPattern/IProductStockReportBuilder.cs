namespace DesignPatternsTraining.BuilderDesignPattern
{
    public interface IProductStockReportBuilder
    {
        /*
         * The Builder pattern separates the construction of an object from its 
         * representation so that the same construction process can create different 
         * representations.

           The general idea is that the order in which things happen when an object 
           is instantiated will be the same, but the actual details of those steps change 
           based upon what the concrete implementation is.
         * */
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        ProductStockReport GetReport();
    }
}
