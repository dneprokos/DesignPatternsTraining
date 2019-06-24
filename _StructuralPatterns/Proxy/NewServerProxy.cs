using System;

namespace DesignPatternsTraining.Proxy
{
    class NewServerProxy : IServer
    {
        private string Order;
        private Server _server = new Server();

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
