using System;

namespace DesignPatternsTraining.SOLID_principles._1_Single_responsibility_principle.ExampleWithSrp
{
    /*
     * So SRP says that a class should have only one responsibility and not multiple.
     * So if we apply SRP we can move that logging activity to some other class 
     * who will only look after logging activities.
     */
    class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }

    /*
     * Now customer class can happily delegate the logging activity to the “FileLogger” class 
     * and he can concentrate on customer related activities.
     */
    class CustomerWithSrp
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
                obj.Handle(ex.ToString());
            }
        }
    }

    
}
