using DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageBuilderInterfaces;
using DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageObjects;
using System;
using System.Collections.Generic;

namespace DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageBuilders
{
    public class OrderMessageBuilder : IOrderMessageBuilder
    {
        private OrderMessage _orderMessage;

        #region Builder methods

        public OrderMessageBuilder(List<string> products) 
        { 
            _orderMessage = new OrderMessage(products);
        }
        public IOrderMessageBuilder BuildIsDiscount(bool isDiscount = true) 
        {
            _orderMessage.SetIsDiscount(isDiscount);
            return this; 
        }
        public IOrderMessageBuilder BuildOrderType(string orderType) 
        {
            _orderMessage.SetOrderType(orderType);
            return this; 
        }
        public IOrderMessageBuilder SendMessage()
        {
            Console.WriteLine("###########Order creation message#############");
            Console.WriteLine("MessageID: " + _orderMessage.GetMessageId());
            Console.WriteLine("OrderId: " + _orderMessage.GetOrderId());
            Console.WriteLine("Order Creation DateTime: " + _orderMessage.GetCreationDateTime());
            string orderType = _orderMessage.GetOrderType();
            if (orderType != null) 
                Console.WriteLine("Order Type: " + orderType);
            Console.WriteLine("Ordered with discount: " + _orderMessage.GetIsDiscount());
            Console.WriteLine("Products list: ");
            _orderMessage.GetProducts().ForEach(product => Console.WriteLine(" -" + product));

            return this;
        }

        #endregion

        #region Builder order templates

        public IOrderMessageBuilder BuildDiscountOrder()
        {
            _orderMessage.SetIsDiscount(true);
            return this;
        }
        public IOrderMessageBuilder BuildRetailOrder()
        {
            _orderMessage.SetOrderType("Retail");
            return this;
        }

        #endregion

    }
}
