namespace DesignPatternsTraining.BridgePattern
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
