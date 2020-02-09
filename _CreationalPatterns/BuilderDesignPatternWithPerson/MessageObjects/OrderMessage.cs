using DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.InternalSystemNotPartOfThePattern;
using DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.PersonInterface;
using System;
using System.Collections.Generic;

namespace DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageObjects
{
    public class OrderMessage : IMessage
    {
        private DateTime _createDateTime;
        private string _messageId;
        private string _orderId;
        private string _orderType;
        private bool _isDiscount;
        private List<string> _products;

        public OrderMessage(List<string> products)
        {
            _messageId = IdGeneratorStub.GenerateMessageId();
            _createDateTime = DateTime.UtcNow;
            _orderId = IdGeneratorStub.GenerateOrderId();
            _products = products;
        }

        public DateTime GetCreationDateTime() { return _createDateTime; }
        public string GetMessageId() { return _messageId; }
        public string GetOrderId() { return _orderId; }
        public void SetOrderType(string orderType) { _orderType = orderType; }
        public string GetOrderType() { return _orderType; }
        public List<string> GetProducts() { return _products; }
        public void SetIsDiscount(bool isDiscount ) { _isDiscount = isDiscount; }
        public bool GetIsDiscount() { return _isDiscount; }
    }
}
