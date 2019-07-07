using System;

namespace DesignPatternsTraining.SOLID_principles._5_Dependency_inversion_principle.ExampleBeforeDip
{
    public class CustomerBeforeDip
    {
        private FileLoggerBeforeDip obj = new FileLoggerBeforeDip();
        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }
    }
}
