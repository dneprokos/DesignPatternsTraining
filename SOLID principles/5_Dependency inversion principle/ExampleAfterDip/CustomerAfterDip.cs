using System;

namespace DesignPatternsTraining.SOLID_principles._5_Dependency_inversion_principle.ExampleAfterDip
{
    public class CustomerAfterDip
    {
        private ILogger obj;

        public virtual void Add(int Exhandle)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                if (Exhandle == 1)
                {
                    obj = new EmailLogger();
                }
                else
                {
                    obj = new FileLoggerAfterDip();
                }
                obj.Handle(ex.Message.ToString());
            }
        }
    }
}
