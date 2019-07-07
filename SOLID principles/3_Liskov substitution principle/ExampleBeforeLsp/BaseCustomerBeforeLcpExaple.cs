namespace DesignPatternsTraining.SOLID_principles._3_Liskov_substitution_principle
{
    public class BaseCustomerForLcpExaple
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            // SOme logic
        }
    }
}
