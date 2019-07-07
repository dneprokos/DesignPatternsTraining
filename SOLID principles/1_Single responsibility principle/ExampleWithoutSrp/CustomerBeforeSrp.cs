using System;

namespace DesignPatternsTraining.SOLID_principles._1_Single_responsibility_principle
{
    /*
     A Customer class is doing things WHICH HE IS NOT SUPPOSED TO DO. 
     Customer class should do customer datavalidations, call the customer data access layer etc , 
     but if you see the catch block closely it also doing LOGGING activity. 
     In simple words its over loaded with lot of responsibility.

     So tomorrow if add a new logger like event viewer 
     I need to go and change the “Customer”class, that’s very ODD.
     */
    public class CustomerBeforeSrp
    {
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }
}
