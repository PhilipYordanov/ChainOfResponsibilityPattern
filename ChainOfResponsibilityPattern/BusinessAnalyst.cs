namespace ChainOfResponsibilityPattern
{
    public class BusinessAnalyst : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(BusinessAnalyst));
            base.Handle(requirement);
        }
    }
}
