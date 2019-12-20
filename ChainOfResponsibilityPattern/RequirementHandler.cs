namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Interfaces;

    public abstract class RequirementHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual void Handle(Requirement requirement) => this._nextHandler.Handle(requirement);

        public IHandler SetNext(IHandler handler) => this._nextHandler = handler;
    }
}
