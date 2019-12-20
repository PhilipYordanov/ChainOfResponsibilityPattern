namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IHandler
    {
        void Handle(Requirement requirement);

        IHandler SetNext(IHandler handler);
    }
}
