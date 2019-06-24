namespace DesignPatternsTraining._BehavioralPatterns.MediatorDesignPattern
{
    public class ConcessionsMediator: IMediator
    {
        private NorthConcessionStand _northConcessions;
        private SouthConcessionStand _southConcessions;

        public NorthConcessionStand NorthConcessions
        {
            set { _northConcessions = value; }
        }

        public SouthConcessionStand SouthConcessions
        {
            set { _southConcessions = value; }
        }

        public void SendMessage(string message, ConcessionStand colleague)
        {
            if (colleague == _northConcessions)
            {
                _southConcessions.Notify(message);
            }
            else
            {
                _northConcessions.Notify(message);
            }
        }
    }
}
