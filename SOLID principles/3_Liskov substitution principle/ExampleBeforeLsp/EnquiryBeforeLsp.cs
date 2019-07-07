using System;
using System.Collections.Generic;

namespace DesignPatternsTraining.SOLID_principles._3_Liskov_substitution_principle.ExampleBeforeLsp
{
    public class EnquiryBeforeLsp: BaseCustomerForLcpExaple
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 5;
        }

        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }

    public class CallExampleBeforeLsp
    {
        public void Run()
        {
            var Customers = new List<BaseCustomerForLcpExaple>();
            Customers.Add(new EnquiryBeforeLsp());

            foreach (BaseCustomerForLcpExaple c in Customers)
            {
                c.Add(); //Will throw exception
            }
        }      
    }
}
