namespace DesignPatternsTraining.PrototypeDesignPattern
{
    public class ConcretePrototype2: Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
