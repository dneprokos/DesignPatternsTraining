namespace DesignPatternsTraining.IteratorDesignPattern
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentBean { get; }
    }
}
