namespace DesignPatternsTraining.ChainOfResponsibility
{
    /// <summary>
    /// The Handler abstract class.  Every class which inherits from this will be responsible for a kind of request for the restaurant.
    /// </summary>
    public abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}
