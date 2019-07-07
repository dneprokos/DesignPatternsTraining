namespace DesignPatternsTraining.SOLID_principles._2_Open_closed_principle.ExampleBeforeOpenClosedPrinciple
{
    public class CustomerBeforeOcp
    {
        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public double getDiscount(double TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }

    /*
     * The problem is if we add a new customer type we need to go and add one more “IF” condition 
     * in the “getDiscount” function, in other words we need to change the customer class.

        If we are changing the customer class again and again, 
        we need to ensure that the previous conditions with new one’s are tested again , 
        existing client’s which are referencing this class are working properly as before.

        In other words we are “MODIFYING” the current customer code for every change 
        and every time we modify we need to ensure that all the previous functionalities 
        and connected client are working as before.
     */

}
