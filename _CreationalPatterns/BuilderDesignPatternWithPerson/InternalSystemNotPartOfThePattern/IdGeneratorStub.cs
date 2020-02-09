namespace DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.InternalSystemNotPartOfThePattern
{
    public static class IdGeneratorStub
    {
        private static string _orderIdPrefix = "AA";
        private static string _orderMessagePrefix = "OO";
        private static long _currentOrderNumber = 1;
        private static long _currentMessageId = 1;

        public static string GenerateOrderId()
        {
            var newOrderId = _orderIdPrefix + "-" + _currentOrderNumber;
            _currentOrderNumber++;

            return newOrderId;
        }

        public static string GenerateMessageId()
        {
            var newMesageId = _orderMessagePrefix + _currentMessageId;
            _currentMessageId++;

            return newMesageId;
        }


    }
}
