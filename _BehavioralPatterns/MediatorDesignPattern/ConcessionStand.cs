namespace DesignPatternsTraining._BehavioralPatterns.MediatorDesignPattern
{
    public abstract class ConcessionStand
    {
        protected IMediator mediator;

        public ConcessionStand(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
