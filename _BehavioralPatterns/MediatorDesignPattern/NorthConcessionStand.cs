using System;

namespace DesignPatternsTraining._BehavioralPatterns.MediatorDesignPattern
{
    public class NorthConcessionStand: ConcessionStand
    {
        // Constructor
        public NorthConcessionStand(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: " + message);
        }
    }
}
