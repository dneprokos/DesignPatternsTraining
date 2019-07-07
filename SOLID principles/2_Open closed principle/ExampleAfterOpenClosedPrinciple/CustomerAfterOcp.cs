namespace DesignPatternsTraining.SOLID_principles._2_Open_closed_principle.ExampleAfterOpenClosedPrinciple
{
    /*
     * How about rather than “MODIFYING” we go for “EXTENSION”. 
     * In other words every time a new customer type needs to be added 
     * we create a new class as shown in the below. So whatever is the current code 
     * they are untouched and we just need to test and check the new classes.
     */

    public class CustomerAfterOcp
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    public class SilverCustomer : CustomerAfterOcp
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }

    public class GoldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }

    /*
     * Putting in simple words the “Customer” class is now closed for any new modification 
     * but it’s open for extensions when new customer types are added to the project.
     */
}
