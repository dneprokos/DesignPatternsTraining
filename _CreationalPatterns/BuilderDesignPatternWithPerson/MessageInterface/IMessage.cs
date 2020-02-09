using System;

namespace DesignPatternsTraining._CreationalPatterns.BuilderDesignPatternWithPerson.PersonInterface
{
    public interface IMessage
    {
        string GetMessageId();
        DateTime GetCreationDateTime();
    }
}
