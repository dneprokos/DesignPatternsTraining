namespace DesignPatternsTraining.SOLID_principles._3_Liskov_substitution_principle.ExampleAfterLsp
{
    public class EnquiryAfterLsp : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
