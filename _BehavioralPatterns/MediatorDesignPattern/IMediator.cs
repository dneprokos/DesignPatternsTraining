namespace DesignPatternsTraining._BehavioralPatterns.MediatorDesignPattern
{
    public interface IMediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }
}
