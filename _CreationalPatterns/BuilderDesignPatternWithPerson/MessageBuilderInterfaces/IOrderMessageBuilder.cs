namespace DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.MessageBuilderInterfaces
{
    public interface IOrderMessageBuilder
    {
        IOrderMessageBuilder BuildOrderType(string orderType);
        IOrderMessageBuilder BuildIsDiscount(bool isDiscount);
        IOrderMessageBuilder SendMessage();
    }
}
