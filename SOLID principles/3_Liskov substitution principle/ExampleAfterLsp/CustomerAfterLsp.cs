using System;
using System.Collections.Generic;

namespace DesignPatternsTraining.SOLID_principles._3_Liskov_substitution_principle.ExampleAfterLsp
{
    public class CustomerAfterLsp: IDiscount, IDatabase
    {
        private FileLogger obj = new FileLogger();
        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.Message.ToString());
            }
        }

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }

    class CallAfterLsp {
        public void Run()
        {
            var customers = new List<CustomerAfterLsp>();
            var enquiryAfterLsp = new EnquiryAfterLsp();
            //customers.Add(enquiryAfterLsp); You cannot add it. Because it has other interface.
        }
    }
}
