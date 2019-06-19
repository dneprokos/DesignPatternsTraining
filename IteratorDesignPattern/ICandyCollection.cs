namespace DesignPatternsTraining.IteratorDesignPattern
{
    /// <summary>
    /// The aggregate interface
    /// </summary>
    public interface ICandyCollection
    {
        IJellyBeanIterator CreateIterator();
    }
}
